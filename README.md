# Intuition
<!-- Describe your first thoughts on how to solve this problem. -->
[English]
My first thought was to ensure that each method has a clear responsibility, making the code easier to read and maintain.

[Portuguese]
Meu primeiro pensamento foi separar as responsabilidade para cada metodo, assim deixando o codigo mais limpo e facil leitura.

# Approach
<!-- Describe your approach to solving the problem. -->
[English]
I decided to create the methods IsUpperLetter and IsNotUpper to check whether a letter is uppercase or not. Additionally, I implemented the Validate method to classify words based on their capitalization pattern:

All letters uppercase
All letters lowercase
Only the first letter capitalized
This modular approach keeps the code clean and easier to understand.

The Decection method runs business logic and other methods.
In the DetectCapitalUse method, I validate the value according to the rules.

[Portuguese]
Decidi criar os métodos IsUpperLetter e IsNotUpper para verificar se uma letra está em maiúscula ou não. Além disso, implementei o método Validate para classificar as palavras com base no seu padrão de capitalização:

Todas as letras em maiúsculas
Todas as letras em minúsculas
Apenas a primeira letra em maiúscula
Essa abordagem modular mantém o código limpo e mais fácil de entender.

O método Detection executa a lógica de negócios e chama outros métodos.
No método DetectCapitalUse, valido o valor de acordo com as regras.
