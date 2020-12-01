Fixes to the SiSense API json to make it work with AutoRest

https://support.sisense.com/hc/en-us/community/posts/360026063513-Auto-generated-Net-C-client-using-AutoRest

There are a large number of errors trying to parse the json found at [SiSense API V0.9](https://sisense.dev/swagger-specs/linux/L8.2.4/v0.json), [SiSense API V1.0](https://sisense.dev/swagger-specs/linux/L8.2.4/v1.json) and [SiSense API V2.0](https://sisense.dev/swagger-specs/linux/L8.2.4/v2.json).

## V0.9 & V2.0
See the diff between v0.9.orig.yaml and v0.9.yaml and v2.0.orig.yaml and v2.0.yaml.

## V1.0
This is still a work in progress.

## Generating clients with AutoRest

``` ps
autorest --input-file=v0.9.yaml --csharp --output-folder=src/UnOffSiSenseDotNet/V0 --namespace=UnOffSiSenseDotNet.V0

autorest --input-file=v1.0.yaml --csharp --output-folder=src/UnOffSiSenseDotNet/V1 --namespace=UnOffSiSenseDotNet.V1

autorest --input-file=v2.0.yaml --csharp --output-folder=src/UnOffSiSenseDotNet/V2 --namespace=UnOffSiSenseDotNet.V2
```

