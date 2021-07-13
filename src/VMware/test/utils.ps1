function RandomString([bool]$allChars, [int32]$len) {
    if ($allChars) {
        return -join ((33..126) | Get-Random -Count $len | % {[char]$_})
    } else {
        return -join ((48..57) + (97..122) | Get-Random -Count $len | % {[char]$_})
    }
}
$env = @{}
function setupEnv() {
    # Preload subscriptionId and tenant from context, which will be used in test
    # as default. You could change them if needed.
    $env.SubscriptionId = (Get-AzContext).Subscription.Id
    $env.Tenant = (Get-AzContext).Tenant.Id

    $privatecloudname1 = "azps-test-cloud-" + (RandomString -allChars $false -len 3)
    $privatecloudname2 = "azps-test-cloud-" + (RandomString -allChars $false -len 4)
    $rstr1 = RandomString -allChars $false -len 6
    $rstr2 = RandomString -allChars $false -len 6
    $rstr3 = RandomString -allChars $false -len 6
    $rstr4 = RandomString -allChars $false -len 6

    $env.Add("privatecloudname1", $privatecloudname1)
    $env.Add("rstr1", $rstr1)
    $env.Add("rstr2", $rstr2)
    $env.Add("rstr3", $rstr3)
    $env.Add("rstr4", $rstr4)

    $env.Add("location", "australiaeast")

    # Create the test group
    write-host "start to create test group"
    $resourceGroup = "azps-test-grou" #"testgroup" + $env.rstr4
    $env.Add("resourceGroup", $resourceGroup)
    New-AzResourceGroup -Name $resourceGroup -Location $env.location
    New-AzVMwarePrivateCloud -Name $env.privatecloudname1 `
        -ResourceGroupName $resourceGroup -NetworkBlock 192.168.48.0/22 `
        -Sku av36 -ManagementClusterSize 3 -Location $env.location
    
    New-AzVMwarePrivateCloud -Name $env.privatecloudname2 `
        -ResourceGroupName $resourceGroup -NetworkBlock 192.168.48.0/22 `
        -Sku av36 -ManagementClusterSize 3 -Location $env.location

    # For any resources you created for test, you should add it to $env here.
    $envFile = 'env.json'
    if ($TestMode -eq 'live') {
        $envFile = 'localEnv.json'
    }
    set-content -Path (Join-Path $PSScriptRoot $envFile) -Value (ConvertTo-Json $env)
}
function cleanupEnv() {
    # Clean resources you create for testing
    Remove-AzResourceGroup -Name $env.resourceGroup
}

