using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MDSnkeakShop.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeysAndRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_whislist_ID_Scarpa",
                table: "whislist",
                column: "ID_Scarpa");

            migrationBuilder.CreateIndex(
                name: "IX_whislist_ID_Utente",
                table: "whislist",
                column: "ID_Utente");

            migrationBuilder.CreateIndex(
                name: "IX_storicoordine_ID_Ordine",
                table: "storicoordine",
                column: "ID_Ordine");

            migrationBuilder.CreateIndex(
                name: "IX_storicoordine_ID_Utente",
                table: "storicoordine",
                column: "ID_Utente");

            migrationBuilder.CreateIndex(
                name: "IX_scarpacolore_ID_Colore",
                table: "scarpacolore",
                column: "ID_Colore");

            migrationBuilder.CreateIndex(
                name: "IX_scarpacolore_ID_Scarpa",
                table: "scarpacolore",
                column: "ID_Scarpa");

            migrationBuilder.CreateIndex(
                name: "IX_scarpa_ID_Brand",
                table: "scarpa",
                column: "ID_Brand");

            migrationBuilder.CreateIndex(
                name: "IX_scarpa_ID_Categoria",
                table: "scarpa",
                column: "ID_Categoria");

            migrationBuilder.CreateIndex(
                name: "IX_scarpa_ID_Colore",
                table: "scarpa",
                column: "ID_Colore");

            migrationBuilder.CreateIndex(
                name: "IX_scarpa_ID_Modello",
                table: "scarpa",
                column: "ID_Modello");

            migrationBuilder.CreateIndex(
                name: "IX_rifornimento_ID_Magazziniere",
                table: "rifornimento",
                column: "ID_Magazziniere");

            migrationBuilder.CreateIndex(
                name: "IX_rifornimento_ID_Negozio",
                table: "rifornimento",
                column: "ID_Negozio");

            migrationBuilder.CreateIndex(
                name: "IX_piuvenduti_ID_Scarpa",
                table: "piuvenduti",
                column: "ID_Scarpa");

            migrationBuilder.CreateIndex(
                name: "IX_ordine_ID_Scarpa",
                table: "ordine",
                column: "ID_Scarpa");

            migrationBuilder.CreateIndex(
                name: "IX_ordine_ID_Utente",
                table: "ordine",
                column: "ID_Utente");

            migrationBuilder.CreateIndex(
                name: "IX_dettagliscarpa_ID_Scarpa",
                table: "dettagliscarpa",
                column: "ID_Scarpa");

            migrationBuilder.CreateIndex(
                name: "IX_dettagliscarpa_ID_Taglia",
                table: "dettagliscarpa",
                column: "ID_Taglia");

            migrationBuilder.CreateIndex(
                name: "IX_dettaglirifornimento_ID_Colore",
                table: "dettaglirifornimento",
                column: "ID_Colore");

            migrationBuilder.CreateIndex(
                name: "IX_dettaglirifornimento_ID_Rifornimento",
                table: "dettaglirifornimento",
                column: "ID_Rifornimento");

            migrationBuilder.CreateIndex(
                name: "IX_dettaglirifornimento_ID_Scarpa",
                table: "dettaglirifornimento",
                column: "ID_Scarpa");

            migrationBuilder.CreateIndex(
                name: "IX_dettaglirifornimento_ID_Taglia",
                table: "dettaglirifornimento",
                column: "ID_Taglia");

            migrationBuilder.CreateIndex(
                name: "IX_cartacredito_ID_Utente",
                table: "cartacredito",
                column: "ID_Utente");

            migrationBuilder.CreateIndex(
                name: "IX_carrello_ID_Scarpa",
                table: "carrello",
                column: "ID_Scarpa");

            migrationBuilder.CreateIndex(
                name: "IX_carrello_ID_Utente",
                table: "carrello",
                column: "ID_Utente");

            migrationBuilder.AddForeignKey(
                name: "FK_carrello_scarpa_ID_Scarpa",
                table: "carrello",
                column: "ID_Scarpa",
                principalTable: "scarpa",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_carrello_utente_ID_Utente",
                table: "carrello",
                column: "ID_Utente",
                principalTable: "utente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_cartacredito_utente_ID_Utente",
                table: "cartacredito",
                column: "ID_Utente",
                principalTable: "utente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dettaglirifornimento_colore_ID_Colore",
                table: "dettaglirifornimento",
                column: "ID_Colore",
                principalTable: "colore",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dettaglirifornimento_rifornimento_ID_Rifornimento",
                table: "dettaglirifornimento",
                column: "ID_Rifornimento",
                principalTable: "rifornimento",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dettaglirifornimento_scarpa_ID_Scarpa",
                table: "dettaglirifornimento",
                column: "ID_Scarpa",
                principalTable: "scarpa",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dettaglirifornimento_taglia_ID_Taglia",
                table: "dettaglirifornimento",
                column: "ID_Taglia",
                principalTable: "taglia",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dettagliscarpa_scarpa_ID_Scarpa",
                table: "dettagliscarpa",
                column: "ID_Scarpa",
                principalTable: "scarpa",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dettagliscarpa_taglia_ID_Taglia",
                table: "dettagliscarpa",
                column: "ID_Taglia",
                principalTable: "taglia",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ordine_scarpa_ID_Scarpa",
                table: "ordine",
                column: "ID_Scarpa",
                principalTable: "scarpa",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ordine_utente_ID_Utente",
                table: "ordine",
                column: "ID_Utente",
                principalTable: "utente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_piuvenduti_scarpa_ID_Scarpa",
                table: "piuvenduti",
                column: "ID_Scarpa",
                principalTable: "scarpa",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_rifornimento_magazziniere_ID_Magazziniere",
                table: "rifornimento",
                column: "ID_Magazziniere",
                principalTable: "magazziniere",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_rifornimento_negozio_ID_Negozio",
                table: "rifornimento",
                column: "ID_Negozio",
                principalTable: "negozio",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_scarpa_brand_ID_Brand",
                table: "scarpa",
                column: "ID_Brand",
                principalTable: "brand",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_scarpa_categoria_ID_Categoria",
                table: "scarpa",
                column: "ID_Categoria",
                principalTable: "categoria",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_scarpa_colore_ID_Colore",
                table: "scarpa",
                column: "ID_Colore",
                principalTable: "colore",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_scarpa_modello_ID_Modello",
                table: "scarpa",
                column: "ID_Modello",
                principalTable: "modello",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_scarpacolore_colore_ID_Colore",
                table: "scarpacolore",
                column: "ID_Colore",
                principalTable: "colore",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_scarpacolore_scarpa_ID_Scarpa",
                table: "scarpacolore",
                column: "ID_Scarpa",
                principalTable: "scarpa",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_storicoordine_ordine_ID_Ordine",
                table: "storicoordine",
                column: "ID_Ordine",
                principalTable: "ordine",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_storicoordine_utente_ID_Utente",
                table: "storicoordine",
                column: "ID_Utente",
                principalTable: "utente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_whislist_scarpa_ID_Scarpa",
                table: "whislist",
                column: "ID_Scarpa",
                principalTable: "scarpa",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_whislist_utente_ID_Utente",
                table: "whislist",
                column: "ID_Utente",
                principalTable: "utente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carrello_scarpa_ID_Scarpa",
                table: "carrello");

            migrationBuilder.DropForeignKey(
                name: "FK_carrello_utente_ID_Utente",
                table: "carrello");

            migrationBuilder.DropForeignKey(
                name: "FK_cartacredito_utente_ID_Utente",
                table: "cartacredito");

            migrationBuilder.DropForeignKey(
                name: "FK_dettaglirifornimento_colore_ID_Colore",
                table: "dettaglirifornimento");

            migrationBuilder.DropForeignKey(
                name: "FK_dettaglirifornimento_rifornimento_ID_Rifornimento",
                table: "dettaglirifornimento");

            migrationBuilder.DropForeignKey(
                name: "FK_dettaglirifornimento_scarpa_ID_Scarpa",
                table: "dettaglirifornimento");

            migrationBuilder.DropForeignKey(
                name: "FK_dettaglirifornimento_taglia_ID_Taglia",
                table: "dettaglirifornimento");

            migrationBuilder.DropForeignKey(
                name: "FK_dettagliscarpa_scarpa_ID_Scarpa",
                table: "dettagliscarpa");

            migrationBuilder.DropForeignKey(
                name: "FK_dettagliscarpa_taglia_ID_Taglia",
                table: "dettagliscarpa");

            migrationBuilder.DropForeignKey(
                name: "FK_ordine_scarpa_ID_Scarpa",
                table: "ordine");

            migrationBuilder.DropForeignKey(
                name: "FK_ordine_utente_ID_Utente",
                table: "ordine");

            migrationBuilder.DropForeignKey(
                name: "FK_piuvenduti_scarpa_ID_Scarpa",
                table: "piuvenduti");

            migrationBuilder.DropForeignKey(
                name: "FK_rifornimento_magazziniere_ID_Magazziniere",
                table: "rifornimento");

            migrationBuilder.DropForeignKey(
                name: "FK_rifornimento_negozio_ID_Negozio",
                table: "rifornimento");

            migrationBuilder.DropForeignKey(
                name: "FK_scarpa_brand_ID_Brand",
                table: "scarpa");

            migrationBuilder.DropForeignKey(
                name: "FK_scarpa_categoria_ID_Categoria",
                table: "scarpa");

            migrationBuilder.DropForeignKey(
                name: "FK_scarpa_colore_ID_Colore",
                table: "scarpa");

            migrationBuilder.DropForeignKey(
                name: "FK_scarpa_modello_ID_Modello",
                table: "scarpa");

            migrationBuilder.DropForeignKey(
                name: "FK_scarpacolore_colore_ID_Colore",
                table: "scarpacolore");

            migrationBuilder.DropForeignKey(
                name: "FK_scarpacolore_scarpa_ID_Scarpa",
                table: "scarpacolore");

            migrationBuilder.DropForeignKey(
                name: "FK_storicoordine_ordine_ID_Ordine",
                table: "storicoordine");

            migrationBuilder.DropForeignKey(
                name: "FK_storicoordine_utente_ID_Utente",
                table: "storicoordine");

            migrationBuilder.DropForeignKey(
                name: "FK_whislist_scarpa_ID_Scarpa",
                table: "whislist");

            migrationBuilder.DropForeignKey(
                name: "FK_whislist_utente_ID_Utente",
                table: "whislist");

            migrationBuilder.DropIndex(
                name: "IX_whislist_ID_Scarpa",
                table: "whislist");

            migrationBuilder.DropIndex(
                name: "IX_whislist_ID_Utente",
                table: "whislist");

            migrationBuilder.DropIndex(
                name: "IX_storicoordine_ID_Ordine",
                table: "storicoordine");

            migrationBuilder.DropIndex(
                name: "IX_storicoordine_ID_Utente",
                table: "storicoordine");

            migrationBuilder.DropIndex(
                name: "IX_scarpacolore_ID_Colore",
                table: "scarpacolore");

            migrationBuilder.DropIndex(
                name: "IX_scarpacolore_ID_Scarpa",
                table: "scarpacolore");

            migrationBuilder.DropIndex(
                name: "IX_scarpa_ID_Brand",
                table: "scarpa");

            migrationBuilder.DropIndex(
                name: "IX_scarpa_ID_Categoria",
                table: "scarpa");

            migrationBuilder.DropIndex(
                name: "IX_scarpa_ID_Colore",
                table: "scarpa");

            migrationBuilder.DropIndex(
                name: "IX_scarpa_ID_Modello",
                table: "scarpa");

            migrationBuilder.DropIndex(
                name: "IX_rifornimento_ID_Magazziniere",
                table: "rifornimento");

            migrationBuilder.DropIndex(
                name: "IX_rifornimento_ID_Negozio",
                table: "rifornimento");

            migrationBuilder.DropIndex(
                name: "IX_piuvenduti_ID_Scarpa",
                table: "piuvenduti");

            migrationBuilder.DropIndex(
                name: "IX_ordine_ID_Scarpa",
                table: "ordine");

            migrationBuilder.DropIndex(
                name: "IX_ordine_ID_Utente",
                table: "ordine");

            migrationBuilder.DropIndex(
                name: "IX_dettagliscarpa_ID_Scarpa",
                table: "dettagliscarpa");

            migrationBuilder.DropIndex(
                name: "IX_dettagliscarpa_ID_Taglia",
                table: "dettagliscarpa");

            migrationBuilder.DropIndex(
                name: "IX_dettaglirifornimento_ID_Colore",
                table: "dettaglirifornimento");

            migrationBuilder.DropIndex(
                name: "IX_dettaglirifornimento_ID_Rifornimento",
                table: "dettaglirifornimento");

            migrationBuilder.DropIndex(
                name: "IX_dettaglirifornimento_ID_Scarpa",
                table: "dettaglirifornimento");

            migrationBuilder.DropIndex(
                name: "IX_dettaglirifornimento_ID_Taglia",
                table: "dettaglirifornimento");

            migrationBuilder.DropIndex(
                name: "IX_cartacredito_ID_Utente",
                table: "cartacredito");

            migrationBuilder.DropIndex(
                name: "IX_carrello_ID_Scarpa",
                table: "carrello");

            migrationBuilder.DropIndex(
                name: "IX_carrello_ID_Utente",
                table: "carrello");
        }
    }
}
