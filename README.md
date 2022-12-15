# Juvenile-Case-Number-Validator-Module
## This module is deployed as a service for Molecule Software Systems

## What does it do? 
The case number validator ensures that a juvenile case number is valid. 

## How does it work? 
The validator is called by installing and referencing the library, then calling ConfirmValidJuvenileCaseNumber on any string, then passing the CaseTypes enumerable value as a single parameter. 
For example **"22 JA 000001".ConfirmValidJuvenileCaseNumber(CaseTypes.AbuseNeglectDependency);**

## What does the extension method return
The extension returns a **boolean** value
