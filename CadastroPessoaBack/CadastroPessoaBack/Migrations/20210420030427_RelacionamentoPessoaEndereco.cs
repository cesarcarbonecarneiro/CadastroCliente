using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroPessoaBack.Migrations
{
    public partial class RelacionamentoPessoaEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Pessoas_PessoaId",
                table: "Enderecos");

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Pessoas_PessoaId",
                table: "Enderecos",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Pessoas_PessoaId",
                table: "Enderecos");

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Pessoas_PessoaId",
                table: "Enderecos",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
