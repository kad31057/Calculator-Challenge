#!/bin/bash

# Define the content of the README.md
readme_content="# Calculator Challenge

A basic calculator console application written in **C#** that performs addition based on specific rules. This application is designed to handle various input formats and delimiters, as outlined in the challenge requirements.

## Features

- Adds numbers provided in a single formatted string.
- Supports:
  - Comma and newline as default delimiters.
  - Custom delimiters, including multiple and multi-character delimiters.
  - Handling of negative numbers with clear error messages.
  - Ignoring numbers greater than 1000.
- Unit-tested to verify functionality.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (6.0 or later) installed.

### Clone the Repository

\`\`\`bash
git clone https://github.com/your-username/CalculatorChallenge.git
cd CalculatorChallenge
\`\`\`

### Run the Application

1. **Navigate to the project folder**:

   \`\`\`bash
   cd CalculatorApp
   \`\`\`

2. **Run the application**:

   \`\`\`bash
   dotnet run
   \`\`\`

3. **Input Examples**:
   - Basic addition: \`1,2\` ➔ Output: \`3\`
   - Custom delimiter: \`//#\\n2#5\` ➔ Output: \`7\`
   - Multiple delimiters: \`//[*][!!][r9r]\\n11r9r22*hh*33!!44\` ➔ Output: \`110\`
   - Negative number handling: \`1,-2\` ➔ Error: \"Negatives not allowed: -2\"

4. **Exit** by typing \`exit\` anytime.

## Running the Tests

1. **Navigate to the test project folder**:

   \`\`\`bash
   cd CalculatorApp.Tests
   \`\`\`

2. **Run the tests**:

   \`\`\`bash
   dotnet test
   \`\`\`

## Project Structure

- **CalculatorApp**: Console application that handles input and displays results.
- **CalculatorApp.Tests**: NUnit test project containing tests for each requirement.

## Example Use Cases

- **Input**: \`2,3,1001\`
  - **Output**: \`5\` (Ignores 1001, as it exceeds 1000)
- **Input**: \`//[*]\\n1*2*3\`
  - **Output**: \`6\` (Custom single character delimiter \`*\`)
- **Input**: \`1\\n2,3\`
  - **Output**: \`6\` (Handles both newline and comma delimiters)

## Requirements Implemented

1. **Basic Addition** - Sum up to two numbers with comma as a delimiter.
2. **Unlimited Numbers** - Handles more than two numbers.
3. **Multiple Delimiters** - Supports newline and custom delimiters.
4. **Error Handling** - Shows an error for negative numbers.
5. **Ignore Large Numbers** - Ignores any number greater than 1000.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details."

# Write content to README.md
echo "$readme_content" > README.md

# Notify user
echo "README.md file created successfully."
