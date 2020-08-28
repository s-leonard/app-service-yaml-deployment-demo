# Azure App Service & Azure DevOps YAML Pipelines

In this guide we will show you how you can 

- Deploy ASP.NET Core applications to multiple Azure App Service environments with YAML based pipelines
- Change the Application Configs per environment
- Implement manual approval gates for certain environments 
- Make use of Manged Service Identies to automatically inject secrets from Azure Key Vault into your applications


## Deploying the resources to Azure

First we need to deploy the resources to Azure. In this demo we are going to keep things simple and create just a single App Service with multiple deployment slots, but the pipeline could be changed to deploy to completely seperate App Service within seperate subscriptions. 


[![Deploy to Azure](https://aka.ms/deploytoazurebutton)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fs-leonard%2Fapp-service-yaml-deployment-demo%2Fmaster%2FARMTemplate%2Ftemplate.json)