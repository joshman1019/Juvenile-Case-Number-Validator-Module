# Juvenile-Case-Number-Validator-Module
## This module is deployed as a service for Molecule Software Systems

## Before we get started... what are the requirements for juvenile case numbers
|Section|Required Formatting|Notes|
|-------|-------------------|-----|
|Year|00|Two digit representation of the year|
|Case Type|JX|Two digit representation of case type|
|Sequence|000000|One to six digit representation of the case sequence|

**NOTE: A single space is required between each segment**

## What should the case number look like when it is correct
There are two formats of case number that are acceptable on documents
* **00 JA 000011**
* **00 JA 11**

## What different case types are represented by a juvenile case number
* **00 JA 000000** Abuse/Neglect/Dependency
* **00 JB 000000** Delinquency / Undisciplined
* **00 JT 000000** Termination of Parental Rights
* **00 JE 000000** Emancipation
* **00 JR 000000** Petn. Judicial Review of Responsible Individuals List
* **00 JW 000000** Judicial Waiver of Parental Consent

## What options are available for **CaseType**
* **AbuseNeglectDependency** | Abuse / Neglect / Dependency
* **Delinquent** | Delinquent / Undisciplined
* **TerminationOfParentalRights** | Termination of Parental Rights
* **Emancipation** | Emancipation
* **ResponsibleIndividualsList** | Petn. Judicial Review of Responsible Individuals List
* **JudicialWaiver** | Judicial Waiver

## What does the module do? 
The case number validator ensures that a juvenile case number is valid. 

## How does it work? 
The validator is called by installing and referencing the library, then calling ConfirmValidJuvenileCaseNumber on any string, then passing the CaseTypes enumerable value as a single parameter. 
For example 
```
"22 JA 000001".ConfirmValidJuvenileCaseNumber(CaseTypes.AbuseNeglectDependency);
```
## What is the proper using statement
```c#
using JCNV; 
```

## What does the extension method return
The extension returns a **boolean** value
