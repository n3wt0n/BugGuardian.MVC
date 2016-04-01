param($installPath, $toolsPath, $package, $project)

# open DBTek.BugGuardian.MVC splash page on package install

try
{
  $url = "https://github.com/n3wt0n/BugGuardian.MVC/wiki/Configuration"
  $dte2 = Get-Interface $dte ([EnvDTE80.DTE2])
  $dte2.ItemOperations.Navigate($url) | Out-Null      
}
catch
{
  # stop potential errors from bubbling up
  # worst case the splash page won't open  
}