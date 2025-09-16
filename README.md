# Refactoring and Internationalization of the DevelopmentChallenge Project

## Objective

Standardize the use of languages in the project using the `LanguageEnum` (EN, ES, IT) for internationalization, eliminating the use of loose strings and making the code safer, more robust, and easier to maintain. All tests and geometric report features have been adapted to use the enum.

---

## Changes Made

### 1. Language Enum
- Created/Standardized the `LanguageEnum` in `DevelopmentChallenge.Data.Enum.LanguageEnum.cs`:
  ```csharp
  public enum LanguageEnum
  {
      EN,
      ES,
      IT
  }
  ```

### 2. LanguageDictionary
- Methods `Register` and `Translate` now accept `LanguageEnum` as a parameter.
- Added a private method to convert `LanguageEnum` to string ("en", "es", "it").
- Kept overloads for string for backward compatibility.
- Example usage:
  ```csharp
  LanguageDictionary.Register(LanguageEnum.EN, translations);
  var text = LanguageDictionary.Translate(LanguageEnum.EN, "ReportHeader");
  ```

### 3. ShapeReport
- Method `PrintReport` now receives `LanguageEnum` instead of string.
- All internal translations use `LanguageDictionary.Translate(LanguageEnum, ...)`.
- Example usage:
  ```csharp
  var report = ShapeReport.PrintReport(shapes, LanguageEnum.EN);
  ```

### 4. Automated Tests
- All tests in `DataTests.cs` have been adapted to use `LanguageEnum`.
- All translation registrations and report generations use the enum.
- Example:
  ```csharp
  LanguageDictionary.Register(LanguageEnum.EN, ...);
  var report = ShapeReport.PrintReport(shapes, LanguageEnum.EN);
  ```
- Tests cover all scenarios: empty list, multiple types, pluralization, internationalization, presence of labels and translated names.

### 5. Shape Classes
- No structural changes needed in shape classes (`Shape`, `Square`, `Circle`, etc.), as they already use enum for shape type.

---

## Refactoring Benefits
- **Safety:** Prevents language typo errors.
- **Standardization:** The entire project uses the enum for language.
- **Maintainability:** Facilitates future language additions.
- **Testability:** Automated tests ensure correct operation in all languages.

---

## How to Use

1. **Register translations:**
   ```csharp
   LanguageDictionary.Register(LanguageEnum.EN, new Dictionary<string, string> { ... });
   ```
2. **Generate report:**
   ```csharp
   var report = ShapeReport.PrintReport(shapes, LanguageEnum.EN);
   ```
3. **Translate labels:**
   ```csharp
   var label = LanguageDictionary.Translate(LanguageEnum.ES, "Area");
   ```

---

## How to Run Tests

You can run all automated tests or individual tests using the .NET CLI or your preferred IDE.

### 1. Run All Tests (Command Line)

From the root of the solution or the test project folder, run:
```sh
dotnet test
```
This will execute all tests in the solution and show a summary of results.

### 2. Run a Specific Test by Name

To run a single test method, use the `--filter` option with the test name:
```sh
dotnet test --filter FullyQualifiedName~DevelopmentChallenge.Data.Tests.DataTests.TestShapeReportForEachShape_NewPOO
```
Replace the method name with the one you want to run.

### 3. Run All Tests in a Specific Class

To run all tests in a class:
```sh
dotnet test --filter FullyQualifiedName~DevelopmentChallenge.Data.Tests.DataTests
```

### 4. Run Tests in Visual Studio or Rider

- **Visual Studio:**
  - Open the Test Explorer (Test > Test Explorer).
  - Click "Run All" to execute all tests.
  - Right-click a test or class to run it individually.
- **JetBrains Rider:**
  - Open the Unit Tests window.
  - Run all tests, a specific class, or a single test by clicking the play icons.

---

## Tests
- All automated tests have been adapted and validated for enum usage.
- Cover all relevant scenarios for internationalization and geometric reports.

---

## Notes
- The project is ready to receive new languages, just add to the enum and the conversion method.
- The use of the enum can be extended to other areas of the system that depend on internationalization.

---

## Libraries and Frameworks Used

### .NET Version
- **.NET SDK:** 9.0.305 (project targets .NET 8.0)

### Main Libraries
- **Newtonsoft.Json** (13.0.3)
  - For JSON serialization/deserialization.
- **NCalcSync** (5.6.0)
  - For mathematical expression evaluation (if used in formulas).

### Test Libraries
- **xUnit** (2.9.3)
  - Main test framework used in DataTests.cs.
- **xunit.runner.visualstudio** (2.9.3)
  - Visual Studio integration for xUnit.
- **Microsoft.NET.Test.Sdk** (17.6.3)
  - Test SDK for running tests.
- **MSTest.TestAdapter** (2.1.2) and **MSTest.TestFramework** (2.1.2)
  - MSTest support (not used in current test code, but available).
- **NUnit** (3.12.0), **NUnit.ConsoleRunner** (3.11.1), **NUnit3TestAdapter** (3.17.0)
  - NUnit support (not used in current test code, but available).

## IDEs Used

The project was successfully executed and validated in the following IDEs:

- **JetBrains Rider**: All features and tests ran without issues.
- **Visual Studio Code**: The project was opened, built, and all tests executed successfully using the integrated terminal and .NET extensions.

---


### Project Structure
- **DevelopmentChallenge.Data**: Main library with business logic and shape classes.
- **DevelopmentChallenge.Data.Tests**: Test project with all automated tests.

---

**Refactoring completed and validated!**
