using System;
using Api.Data.Collections;
using Api.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfectadoController: ControllerBase
    {
        Data.MongoDB _mongoDB;
        IMongoCollection<Infectado> _InfectadosCollection;

        public InfectadoController(Data.MongoDB mongoDB)
        {
            _mongoDB = mongoDB;
            _InfectadosCollection = mongoDB.DB.GetCollection<Infectado>(typeof(Infectado).Name.ToLower());
        }

        [HttpPost]
        public ActionResult SalvarInfectado([FromBody] InfectadoDto dto)
        {
            var infectado = new Infectado(dto.DataNascimento, dto.Sexo, dto.Latitude, dto.Longitude);

            _InfectadosCollection.InsertOne(infectado);

            return StatusCode(201, "Infectado adicionado com sucesso!");
        }

        [HttpGet]
        public ActionResult ObterInfectados()
        {
            var infectados = _InfectadosCollection.Find(Builders<Infectado>.Filter.Empty).ToList();

            return Ok(infectados);
        }

        [HttpPut]
        public ActionResult AtualizarInfectado([FromBody] InfectadoDto dto)
        {
           _InfectadosCollection.UpdateOne(Builders<Infectado>.Filter.Where(_ => _.DataNascimento == 
           dto.DataNascimento), Builders<Infectado>.Update.Set("sexo", dto.Sexo));

            return Ok("Atualizado com sucesso!");
        }

        [HttpDelete("{dataNasc}")]
        public ActionResult DeletarInfectado(string dataNasc)
        {
           _InfectadosCollection.DeleteOne(Builders<Infectado>.Filter.Where(_ => _.DataNascimento == 
           Convert.ToDateTime(dataNasc)));

            return Ok("Deletado com sucesso!");
        }
    }
}