# Test Plan

## Introduction
This document is written with the porpuse to list and describe all the types of tests that we are going to execute to the *AntAlgorithm* program. This document includes the type of tests and the different test scenarios.
## Tests

- Unit Tests
- End-to-End Tests

## Testing Tools
- NUnit

## Scenarios
|  ID|  Description|Input| Success  | Failed| 
|--|--|--|--|--|--|
| Scen-1 | Testing Ants string | "..ant.ant...naat..anta..n...t"| 2 | different from 2|
|Scen-2   | Testing Ants string | ".ant....ant...tan..ant"  | 1 |different from 1|
| Scen-3  |Testing data type validation  |  50 | "That data type isnt valid" |Unhandled Exception|
| Scen-4  |Testing Ants string  | "antantantantat"  | 1 |different from 1|
| Scen-5  |Testing Ants string  | "ant......t......a.....t"  |2|different from 2|


