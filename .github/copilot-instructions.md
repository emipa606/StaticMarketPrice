# Copilot Instructions for Static Market Price (Continued)

## Mod Overview and Purpose

The "Static Market Price (Continued)" mod simplifies the trading system in RimWorld by making purchase and sell prices static and equal to the item's intrinsic market value. This modification aims to alleviate the frustration of fluctuating prices due to various in-game factors, providing a more straightforward and less variable trading experience while maintaining the challenge of existing trade systems without providing unrealistic complexities.

## Key Features and Systems

- **Static Pricing Mechanism**: Ensures that the buy and sell prices of items always match their market value, negating any manipulation through difficulty settings or social skill variations.
- **Elimination of Multipliers**: Removes specific trade multipliers such as the hard-coded 50% sell and 150% buy factors, standardizing the trading process.
- **Selective Item Price Adjustments**: Preserves price doubling for certain commodities available through specific orbital traders.
- **Compatibility and Flexibility**: The mod boasts compatibility with all save versions and can be removed without impacting game stability.

## Coding Patterns and Conventions

- **Naming Conventions**: Use PascalCase for class and method names. Keep the naming descriptive to enhance readability.
- **Static Classes and Methods**: The mod employs static classes and methods to manage logic, indicative of functionality that doesn't rely on instance-specific data.
- **Namespace Management**: Adhere to proper namespace definitions that correlate with the mod's folder structure to avoid conflicts and increase clarity.

## XML Integration

- **XML Data Utilization**: For an efficient integration between C# code and XML data configurations, consider leveraging XML patch operations to modify base game data where necessary. This can include updating price definitions if dictated through XML.
  
## Harmony Patching

- **Harmony Library Usage**: The core strategy for modifying base RimWorld operations without altering the original code involves using the Harmony library to patch methods:
  - **Postfixes**: Add logic after original method execution to adjust market prices.
  - **Prefixes**: Alter or substitute calculations to control price factors prior to their application.
- **Non-Invasive Strategy**: Ensure patches do not disrupt game stability by avoiding destructive method overrides and validating all changes through extensive testing.

## Suggestions for Copilot

- **Code Commenting**: Copilot can assist with generating thorough and helpful comments for each significant method and complex logic section. Encourage explanation of logic paths that influence external dependencies or integrations.
- **Efficient Code Snippets**: Utilize Copilot to generate boilerplate for repetitive code structures, such as standard Harmony patch templates or XML handler operations.
- **Error Handling**: Implement robust error handling using try-catch blocks with helpful logs and alerts to aid debugging and improve user experience.
- **AI-Based Suggestions**: Leverage Copilot's contextual understanding to suggest improvements in logic simplification and operation efficiency, especially when optimizing the static pricing calculations.

By maintaining clear documentation and adhering to these instructions, contributors can effectively engage with and further the development of the "Static Market Price (Continued)" mod, ensuring it remains robust, user-friendly, and in-line with RimWorld's evolving modding ecosystem.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.
