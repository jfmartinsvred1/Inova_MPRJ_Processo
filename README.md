MPRJ Inova API - Readme

Descrição

API de exemplo, desenvolvida como parte do processo seletivo para o MPRJ Inova. Esta API em NET Core fornece acesso a quatro endpoints principais para consultas diversas, incluindo consulta de CEP, consulta de corretoras, consulta de corretoras por CNPJ e consulta de feriados.

Ferramentas e versões utilizadas

Desenvolvida em Net Core versão NET 6.0
Instalação

    1. Deverá instalar o SDK .NET 6.0 ou superior.


Comandos para execução local

    1. Entrar na pasta /Desafio_Backend
	2. Abrir o prompt neste diretório
	3. Digitar o codigo "dotnet run" dentro do diretório /Inova_MPRJ/Desafio_Backend
	4. Abrir no navegador a url como padrão "https://localhost:7053/swagger/index.html", caso a url passada no prompt seja diferente da porta 7053 passe a url indicada + /swagger/index.html caso a url nâo seja a mesma indicada

Endpoints Disponíveis

1. Consulta de CEP

	•	Endpoint: /api/cep/{cep}
	•	Método: GET
	•	Descrição: Retorna informações relacionadas ao CEP fornecido, incluindo detalhes sobre o endereço.

2. Consulta de Corretoras

	•	Endpoint: /api/corretoras
	•	Método: GET
	•	Descrição: Retorna uma lista de corretoras disponíveis, fornecendo informações básicas sobre cada uma.

3. Consulta de Corretoras por CNPJ

	•	Endpoint: /api/corretoras/{cnpj}
	•	Método: GET
	•	Descrição: Fornece informações detalhadas sobre uma corretora específica, identificada pelo seu CNPJ.

4. Consulta de Feriados

	•	Endpoint: /api/feriados
	•	Método: GET
	•	Descrição: Retorna uma lista dos próximos feriados, oferecendo detalhes sobre cada data comemorativa.

Exemplos de Uso

Consulta de CEP

curl -X GET "https://localhost:5001/api/v1/Cep/buscar/{cep}" 

Consulta de Corretoras

curl -X GET "https://localhost:5001/api/v1/Corretora/buscar"

Consulta de Corretoras por CNPJ

curl -X GET "https://localhost:5001/api/v1/Corretora/buscar/{cnpj}"

Consulta de Feriados

curl -X GET "https://localhost:5001/api/v1/Feriado/buscar/{ano}" 


https://localhost:5001

Considerações Finais

A API MPRJ Inova é uma ferramenta poderosa para obter informações relevantes.

