using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alunos.API.Data;
using Alunos.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Alunos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunosController : ControllerBase
    {
        private readonly DataContext _context;

        public AlunosController(DataContext context)
        {
            this._context = context;

        }

        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return _context.Alunos;
        }

        // [HttpGet("{id}")]
        // public IEnumerable<Aluno> Get(int Id)
        // {
        //     return _context.Alunos.Where(aluno => aluno.AlunoId == Id);
        // }

        // [HttpGet("{Nome}")]
        // public IEnumerable<Aluno> Get(string Nome)
        // {
        //     return _context.Alunos.Where(aluno => aluno.Nome.Contains(Nome));
        // }


        [HttpGet("{id}")]
        public Aluno Get(int Id)
        {
            return _context.Alunos.FirstOrDefault(aluno => aluno.AlunoId == Id);
        }        

    }
}
