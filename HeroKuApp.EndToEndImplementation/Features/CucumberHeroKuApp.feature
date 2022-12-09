Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](HeroKuApp.EndToEndImplementation/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Verify HeroKuApp HomePage Heading
	Given Webpage is launched
	When Homepage heading is selected
	Then Verifing homepage heading
	And Close the browser