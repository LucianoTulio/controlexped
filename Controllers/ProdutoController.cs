using ControlExped.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControlExped.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase
{
    private  readonly ProdutoServices _produtoServices; 
    
    private readonly ILogger<ProdutoController> _logger;

    public ProdutoController(ILogger<ProdutoController> logger,ProdutoServices produtoServices)
    {
        _logger = logger;
        _produtoServices = produtoServices;
    }

    [HttpGet]
    public async Task<List<Produto>> GetProdutos() => await _produtoServices.GetAsync(); 

    


    [HttpPost]
    public async Task<Produto> PostProduto(Produto produto){

        await _produtoServices.CreateAsync(produto);  
        return produto;
    } 

    [HttpPut]
    public async Task<Produto> UpdateProduto(string id, Produto produto){

        await _produtoServices.UpdateAsync(id, produto);  
        return produto; 

    } 

     [HttpDelete]
    public async Task DeleteProduto(string id){

        await _produtoServices.RemoveAsync(id);  
        

    } 




  
}
