using System;
using Microsoft.AspNetCore.Mvc;
using MyAppWeb.Entidades;

namespace MyAppWeb.Controllers
{
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        
        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        
        [HttpGet]
        public IActionResult GET()
        {
            try
            {
                return Ok(_produtoRepository.ListarProdutos());
            }
            catch (Exception ex)
            {
                return BadRequest("Erro: "+ ex.Message);
            }
        }
        
        [HttpGet("{id:int}")]

        public IActionResult GET(int id)
        {
            try
            {
                var produto = _produtoRepository.ObterProdutoPorId(id);
                return Ok(produto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro:{ex.Message}");
            }
        }
            
        [HttpPost]
        public IActionResult Post(Produto produto)
        {
            try
            {
                _produtoRepository.Salvar(produto);

                return Created("/api/produto", produto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro:{ex.Message}");
            }
        }
    }
}