# Bookstore 📚
### Aluno: Thiago Bittencourt Santana
![30paul1-videoSixteenByNine3000](https://github.com/oThiagoBittencourt/BookStore/assets/106789198/5e982def-5da7-46f6-9186-3190ab783957)


**Projeto acadêmico que visa desenvolver o API Backend de uma livraria utilizando o Entity Framework**

### Sobre o Projeto:
A aplicação se trata do desenvolvimento web de uma livraria, em estágio inicial de Backend. A API apresenta até o momento: estruturação MVC básica, CRUD das entidades, conexão com SQL Server utilizando o Entity Framewor, padrão de repositório e DI.

### Como Funciona:
- O vendedor poderá criar um vasto catálogo de livros;
- O vendedor poderá cadastrar seus compradores;
- O vendedor poderá realizar a venda de livros para os compradores cadastrados;
- Todo o controle de preço total e gerenciamento de estoque, será feita pelo próprio sistema.

### Tecnologias Utilizadas:
- Web API
- Entity Framework
- Sql Server
- Chat GPT

### Detalhes:
- **Models:** Livro, Autor, Genero, Editora, Venda, Client
duration, listed_in, description
- Toda a documentação do projeto está presente dentro do próprio código, ou através de arquivos .txt nas pastas da aplicação!


### Chat GPT:
O Chat GPT foi utilizado para a geração básica dos modelos de CRUD assíncronos, onde o resultado foi devidamente tratado e adaptado no projeto.
- **Solicitado:**
> Gere um modelo de CRUD em C# com métodos assíncronos e interior vazios, para se usar com Swagger
- **Resultado:**
```c#
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class EntityController : ControllerBase
{
    // Corpo vazio, você deve implementar a lógica de injeção de dependência aqui

    [HttpPost]
    [ProducesResponseType(201, Type = typeof(Entity))]
    public async Task<IActionResult> CreateAsync([FromBody] Entity entity)
    {
        // Corpo vazio, você deve implementar a lógica de criação aqui
        return CreatedAtAction("GetEntity", new { id = entity.Id }, entity);
    }

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(List<Entity>))]
    public async Task<IActionResult> ReadAsync()
    {
        // Corpo vazio, você deve implementar a lógica de leitura aqui
        return Ok(new List<Entity>());
    }

    [HttpGet("{id}")]
    [ProducesResponseType(200, Type = typeof(Entity))]
    public async Task<IActionResult> GetEntity(int id)
    {
        // Corpo vazio, você deve implementar a lógica de busca por ID aqui
        return Ok(new Entity());
    }

    [HttpPut("{id}")]
    [ProducesResponseType(204)]
    public async Task<IActionResult> UpdateAsync(int id, [FromBody] Entity entity)
    {
        // Corpo vazio, você deve implementar a lógica de atualização aqui
        return NoContent();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(204)]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        // Corpo vazio, você deve implementar a lógica de exclusão aqui
        return NoContent();
    }
}

```

### Diagrama:
Diagrama do banco de dados
![ProjetoDBModulation](https://github.com/oThiagoBittencourt/BookStore/assets/106789198/0f593a81-1baf-4cce-ba18-09bf3624029a)
