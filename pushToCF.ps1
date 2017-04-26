Param(
  [string]$appName,
  [string]$options
)

iex "& cf push $appName $options"