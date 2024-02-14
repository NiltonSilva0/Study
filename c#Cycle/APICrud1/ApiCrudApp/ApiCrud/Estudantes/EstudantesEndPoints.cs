using ApiCrud.Data;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Estudantes
{
    public static class EstudantesEndPoints
    {
        public static void AddRotasEstudantes(this WebApplication app)
        {
            var rotasEstudantes = app.MapGroup("estudantes");

            //Criar Rotas/Endpoints
            //CREATE
            rotasEstudantes.MapPost("", async (AddEstudanteRequest request, AppDbContext context, CancellationToken ct) =>
            {

                var nomeUnico = await context.Estudantes.AnyAsync(estudante => estudante.Nome == request.Nome);
                if (nomeUnico)
                {
                    return Results.Conflict("Ja existe esse nome no banco de dados.");
                }

                var novoEstudante = new Estudante(request.Nome);
                await context.Estudantes.AddAsync(novoEstudante, ct);
                await context.SaveChangesAsync(ct);

                var estudanteRetorno = new EstudanteDto(novoEstudante.Id, novoEstudante.Nome);
                return Results.Ok(estudanteRetorno);
            });
            //RETORNAR TODOS OS ESTUDANTES CADASTRADOS
            rotasEstudantes.MapGet("", async (AppDbContext context) =>
            {
                var estudantes = await context
                .Estudantes
                .Where(estudante => estudante.Ativo)
                .Select(estudante => new EstudanteDto(estudante.Id, estudante.Nome))
                .ToListAsync();
                return Results.Ok(estudantes);
            });
            //ATUALIZAR ESTUDANTES/UPDATE
            rotasEstudantes.MapPut("{id}", async (Guid id,UpdateEstudanteRequest request, AppDbContext context) =>
            {
                var estudante = await context.Estudantes.FirstOrDefaultAsync(estudante => estudante.Id == id);
               
                if (estudante == null)
                {
                    return Results.NotFound();
                }
                estudante.atualizarNome(request.Nome);
                await context.SaveChangesAsync();
                return Results.Ok(new EstudanteDto(estudante.Id, estudante.Nome));

            });
            //DELETAR ESTUDANTES/DELETE
            rotasEstudantes.MapDelete("{id}", async (Guid id, AppDbContext context) =>
            {
                var estudante = await context.Estudantes.FirstOrDefaultAsync(estudante => estudante.Id == id);
                if (estudante == null)
                {
                    return Results.NotFound();
                }
                estudante.desativar();
                await context.SaveChangesAsync();
                return Results.Ok();
            });
        }

    }
}

