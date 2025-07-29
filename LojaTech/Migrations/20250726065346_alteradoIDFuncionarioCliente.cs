using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaTech.Migrations
{
    /// <inheritdoc />
    public partial class alteradoIDFuncionarioCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Clientes_ClienteId",
                table: "Enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Funcionarios_FuncionarioId",
                table: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Enderecos_ClienteId",
                table: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Enderecos_FuncionarioId",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "Enderecos");

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Funcionarios",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Clientes",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_EnderecoId",
                table: "Funcionarios",
                column: "EnderecoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_EnderecoId",
                table: "Clientes",
                column: "EnderecoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Enderecos_EnderecoId",
                table: "Clientes",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Enderecos_EnderecoId",
                table: "Funcionarios",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Enderecos_EnderecoId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Enderecos_EnderecoId",
                table: "Funcionarios");

            migrationBuilder.DropIndex(
                name: "IX_Funcionarios_EnderecoId",
                table: "Funcionarios");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_EnderecoId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Clientes");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Enderecos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FuncionarioId",
                table: "Enderecos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_ClienteId",
                table: "Enderecos",
                column: "ClienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_FuncionarioId",
                table: "Enderecos",
                column: "FuncionarioId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Clientes_ClienteId",
                table: "Enderecos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Funcionarios_FuncionarioId",
                table: "Enderecos",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id");
        }
    }
}
