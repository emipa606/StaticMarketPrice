# GitHub Copilot Instructions for RimWorld Mod: Static Market Price (Continued)

## Overview and Purpose

The *Static Market Price (Continued)* mod for RimWorld aims to simplify trading mechanics by standardizing purchase and sale prices to match an item's market value. This modification removes various trading complexities and inequalities, providing a straightforward and predictable trading experience within the game. The mod eliminates the influence of certain game mechanics on pricing, allowing for more transparent and consistent transactions.

## Key Features and Systems

- **Static Pricing**: The mod ensures that the buy and sell prices for items are equal to their market values, making the trading process simple and predictable.
- **Ignored Modifiers**:
  - Difficulty level-based market price loss.
  - Social skill and pawn trait-based price modifiers.
  - Specific sell price multipliers for items.
- **Removed Factors**: The hard-coded 50% sell price factor and 150% purchase price factor are eliminated, ensuring parity with the item's market value.
- **Orbital Trade Pricing**: Prices for certain goods from specific orbital traders remain at the original game's double pricing, maintaining some strategic elements of trade.

### Compatibility

- **No Conflicts**: The mod is designed to have no compatibility issues.
- **Flexible Use**: Compatible with old saves and can be safely removed at any time.

## Coding Patterns and Conventions

- **Naming**: Classes and methods use PascalCase, such as `StaticMarketPrice_GetPriceFor`.
- **Structure**: The C# project is organized into separate functionality-specific files, e.g., `StaticMarketPrice_GetPriceFor.cs`, `Initialization.cs`, etc.
- **Namespace**: Reflects the theme of the mod and is kept consistent across files.

## XML Integration

The mod contains minimal XML integration, focusing on core functionality changes through C#:

- **About.xml**: This file includes metadata about the mod, such as the display name, author, package ID, and description.
  
Ensure the XML file follows the correct format to enable seamless integration with the game.

## Harmony Patching

The project utilizes Harmony, a popular library for modifying game functions non-invasively:

- **Method Prefixes**: The mod uses Harmony prefixes to modify existing methods. This is showcased in the `StaticMarketPrice_GetPriceFor` and `StaticMarketPrice_GetPriceTooltip` classes where prefix methods are applied to alter trading logic.
- **Initialization**: The `Initialization.cs` file ensures the Harmony patches are applied when the mod is activated.

Ensure Harmony is a dependency in your project setup, as it executes the method modifications properly.

## Suggestions for Copilot

- Implement Helper Methods: Use Copilot to suggest helper methods for repetitive tasks such as fetching item prices or logging operations to maintain cleanliness within the code.
- Consistent Documentation: Create comprehensive summaries and in-line comments in C# files to provide context and enhance readability.
- XML File Manipulation: Use Copilot for generating and maintaining XML structures, especially if future expansions or additional metadata are needed.
- Advanced Harmony Techniques: Leverage Copilot to explore more advanced Harmony patching techniques, like transpilers, if deeper modifications to the game mechanics are necessary in future updates.
  
Following these guidelines and utilizing GitHub Copilot's capabilities will streamline development and maintenance processes while ensuring the mod operates as intended.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

