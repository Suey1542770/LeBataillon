using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeBataillon.Database.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Captain",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "TeamAttacker",
                table: "games");

            migrationBuilder.DropColumn(
                name: "TeamDefendant",
                table: "games");

            migrationBuilder.AddColumn<int>(
                name: "CaptainId",
                table: "teams",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamAttackerId",
                table: "games",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamDefendantId",
                table: "games",
                nullable: true);

            migrationBuilder.InsertData(
                table: "teams",
                columns: new[] { "Id", "CaptainId", "TeamName" },
                values: new object[,]
                {
                    { 1, null, "Équipe de Adrian" },
                    { 2, null, "Équipe de Krissy" },
                    { 3, null, "Équipe de Pat" },
                    { 4, null, "Équipe de Palmira" },
                    { 5, null, "Équipe de Ralph" },
                    { 6, null, "Équipe de Arielle" },
                    { 7, null, "Équipe de Troy" },
                    { 8, null, "Équipe de Marcell" },
                    { 9, null, "Équipe de Vi" },
                    { 10, null, "Équipe de Sherise" }
                });

            migrationBuilder.InsertData(
                table: "games",
                columns: new[] { "Id", "GameDateTime", "TeamAttackerId", "TeamDefendantId" },
                values: new object[,]
                {
                    { 1, new DateTime(220, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 2, new DateTime(220, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4 },
                    { 3, new DateTime(220, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 7 }
                });

            migrationBuilder.InsertData(
                table: "players",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Level", "NickName", "PhoneNumber", "TeamId" },
                values: new object[,]
                {
                    { 1, "Angelina@bataillonMail.com", "Angelina", "Jonkruojis", 0, "AngelinaAlias", "214-764-3816", 1 },
                    { 46, "Liliana@bataillonMail.com", "Liliana", "Clarehurst", 0, "LilianaAlias", "738-487-5562", 7 },
                    { 44, "Roma@bataillonMail.com", "Roma", "Kungstuna", 0, "RomaAlias", "665-811-5544", 7 },
                    { 42, "Tad@bataillonMail.com", "Tad", "Brønnøyden", 0, "TadAlias", "622-523-6527", 7 },
                    { 23, "Jeanetta@bataillonMail.com", "Jeanetta", "Enbo", 0, "JeanettaAlias", "657-456-2877", 7 },
                    { 21, "Roma@bataillonMail.com", "Roma", "Hammervåg", 0, "RomaAlias", "684-168-3851", 7 },
                    { 7, "Sherlene@bataillonMail.com", "Sherlene", "Lystrup", 0, "SherleneAlias", "476-136-1877", 7 },
                    { 86, "Tad@bataillonMail.com", "Tad", "Brønnøyden", 0, "TadAlias", "618-816-4558", 6 },
                    { 84, "Jamal@bataillonMail.com", "Jamal", "Kedainkai", 0, "JamalAlias", "544-428-5532", 6 },
                    { 82, "Eugenie@bataillonMail.com", "Eugenie", "Ketne", 0, "EugenieAlias", "581-122-6515", 6 },
                    { 63, "Arielle@bataillonMail.com", "Arielle", "Balniai", 0, "ArielleAlias", "637-165-2175", 6 },
                    { 61, "Jamal@bataillonMail.com", "Jamal", "Salkile", 0, "JamalAlias", "564-567-2157", 6 },
                    { 40, "Eugenio@bataillonMail.com", "Eugenio", "Kedainkai", 0, "EugenioAlias", "556-135-7581", 6 },
                    { 38, "Palmira@bataillonMail.com", "Palmira", "Ketne", 0, "PalmiraAlias", "583-637-8563", 6 },
                    { 19, "Arielle@bataillonMail.com", "Arielle", "Brønnøyden", 0, "ArielleAlias", "641-572-4833", 6 },
                    { 17, "Jamal@bataillonMail.com", "Jamal", "Kedainkai", 0, "JamalAlias", "576-284-5815", 6 },
                    { 15, "Eugenie@bataillonMail.com", "Eugenie", "Ketne", 0, "EugenieAlias", "523-786-6877", 6 },
                    { 6, "Conrad@bataillonMail.com", "Conrad", "Eqalunavik", 0, "ConradAlias", "758-787-5464", 6 },
                    { 99, "Bianca@bataillonMail.com", "Bianca", "Mõisali", 0, "BiancaAlias", "478-681-3127", 5 },
                    { 80, "Ernestine@bataillonMail.com", "Ernestine", "Hókrókur", 0, "ErnestineAlias", "536-634-7577", 5 },
                    { 65, "Marcell@bataillonMail.com", "Marcell", "Hammervåg", 0, "MarcellAlias", "682-453-1112", 7 },
                    { 67, "Sherise@bataillonMail.com", "Sherise", "Enbo", 0, "SheriseAlias", "645-741-8138", 7 },
                    { 69, "Liliana@bataillonMail.com", "Liliana", "Reidcoln", 0, "LilianaAlias", "718-337-7156", 7 },
                    { 88, "Roma@bataillonMail.com", "Roma", "Kungstuna", 0, "RomaAlias", "663-384-3576", 7 },
                    { 79, "Debi@bataillonMail.com", "Debi", "Boswood", 0, "DebiAlias", "888-475-3174", 9 },
                    { 77, "Derick@bataillonMail.com", "Derick", "Guasabaro", 0, "DerickAlias", "845-887-4156", 9 },
                    { 75, "Nicholas@bataillonMail.com", "Nicholas", "Apatcruz", 0, "NicholasAlias", "872-511-5138", 9 },
                    { 56, "Debi@bataillonMail.com", "Debi", "Boswood", 0, "DebiAlias", "828-544-8588", 9 },
                    { 54, "Pierre@bataillonMail.com", "Pierre", "Guasabaro", 0, "PierreAlias", "865-156-1562", 9 },
                    { 52, "Antonetta@bataillonMail.com", "Antonetta", "Ixtatla", 0, "AntonettaAlias", "811-661-2544", 9 },
                    { 33, "Barbie@bataillonMail.com", "Barbie", "Mensmere", 0, "BarbieAlias", "857-514-6814", 9 },
                    { 31, "Pierre@bataillonMail.com", "Pierre", "Apatcruz", 0, "PierreAlias", "884-226-7876", 9 },
                    { 12, "Debi@bataillonMail.com", "Debi", "Boswood", 0, "DebiAlias", "832-151-3446", 9 },
                    { 9, "Tyson@bataillonMail.com", "Tyson", "Haapsa", 0, "TysonAlias", "441-434-8815", 9 },
                    { 78, "Leida@bataillonMail.com", "Leida", "Kalatee", 0, "LeidaAlias", "463-246-7561", 5 },
                    { 96, "Antonetta@bataillonMail.com", "Antonetta", "Eqalunavik", 0, "AntonettaAlias", "887-154-8576", 8 },
                    { 92, "Magen@bataillonMail.com", "Magen", "Reidcoln", 0, "MagenAlias", "771-268-2532", 8 },
                    { 73, "Conrad@bataillonMail.com", "Conrad", "Eqalunavik", 0, "ConradAlias", "727-223-5112", 8 },
                    { 71, "Tonita@bataillonMail.com", "Tonita", "Nuugaatrapaluk", 0, "TonitaAlias", "764-635-6174", 8 },
                    { 50, "Marcella@bataillonMail.com", "Marcella", "Uummanqaq", 0, "MarcellaAlias", "746-273-3526", 8 },
                    { 48, "Mariella@bataillonMail.com", "Mariella", "Flatwood", 0, "MariellaAlias", "783-785-4588", 8 },
                    { 29, "Conrad@bataillonMail.com", "Conrad", "Eqalunavik", 0, "ConradAlias", "831-638-8858", 8 },
                    { 27, "Tonita@bataillonMail.com", "Tonita", "Nuugaatrapaluk", 0, "TonitaAlias", "766-342-1832", 8 },
                    { 25, "Magen@bataillonMail.com", "Magen", "Reidcoln", 0, "MagenAlias", "722-844-1814", 8 },
                    { 8, "Nicholas@bataillonMail.com", "Nicholas", "Ixtatla", 0, "NicholasAlias", "823-375-4482", 8 },
                    { 90, "Jeanetta@bataillonMail.com", "Jeanetta", "Clarehurst", 0, "JeanettaAlias", "626-772-2514", 7 },
                    { 94, "Tonita@bataillonMail.com", "Tonita", "Nuugaatrapaluk", 0, "TonitaAlias", "744-566-1558", 8 },
                    { 59, "Krissy@bataillonMail.com", "Krissy", "Ólafsholt", 0, "KrissyAlias", "521-271-3131", 5 },
                    { 57, "Johana@bataillonMail.com", "Johana", "Nittinen", 0, "JohanaAlias", "555-683-4113", 5 },
                    { 55, "Sheridan@bataillonMail.com", "Sheridan", "Mõisali", 0, "SheridanAlias", "482-315-5175", 5 },
                    { 89, "Simonne@bataillonMail.com", "Simonne", "Kulli", 0, "SimonneAlias", "288-543-7181", 2 },
                    { 87, "Steven@bataillonMail.com", "Steven", "Ísafholt", 0, "StevenAlias", "235-245-8163", 2 },
                    { 85, "Emely@bataillonMail.com", "Emely", "Rovanola", 0, "EmelyAlias", "272-657-8145", 2 },
                    { 66, "Simonne@bataillonMail.com", "Simonne", "Jaunli", 0, "SimonneAlias", "228-612-4525", 2 },
                    { 64, "Troy@bataillonMail.com", "Troy", "Akssandur", 0, "TroyAlias", "255-214-5587", 2 },
                    { 62, "Ralph@bataillonMail.com", "Ralph", "Rovanola", 0, "RalphAlias", "111-726-6562", 2 },
                    { 43, "Vi@bataillonMail.com", "Vi", "Jaunli", 0, "ViAlias", "247-652-2132", 2 },
                    { 41, "Troy@bataillonMail.com", "Troy", "Akssandur", 0, "TroyAlias", "274-364-3114", 2 },
                    { 22, "Simonne@bataillonMail.com", "Simonne", "Kulli", 0, "SimonneAlias", "232-327-7464", 2 },
                    { 20, "Steven@bataillonMail.com", "Steven", "Ísafholt", 0, "StevenAlias", "266-721-7446", 2 },
                    { 18, "Emely@bataillonMail.com", "Emely", "Rovanola", 0, "EmelyAlias", "213-433-8428", 2 },
                    { 2, "Liliana@bataillonMail.com", "Liliana", "Reidcoln", 0, "LilianaAlias", "742-813-7421", 2 },
                    { 83, "Cathryn@bataillonMail.com", "Cathryn", "Kalvee", 0, "CathrynAlias", "127-361-1128", 1 },
                    { 81, "Marlon@bataillonMail.com", "Marlon", "Dragstrup", 0, "MarlonAlias", "154-773-2182", 1 },
                    { 60, "Pat@bataillonMail.com", "Pat", "Kalvee", 0, "PatAlias", "146-338-7544", 1 },
                    { 58, "Adrian@bataillonMail.com", "Adrian", "Dragstrup", 0, "AdrianAlias", "173-842-8526", 1 },
                    { 39, "Cathryn@bataillonMail.com", "Cathryn", "Siukoski", 0, "CathrynAlias", "131-876-4176", 1 },
                    { 37, "Marlon@bataillonMail.com", "Marlon", "Loktu", 0, "MarlonAlias", "166-488-4158", 1 },
                    { 35, "Rosetta@bataillonMail.com", "Rosetta", "Albro", 0, "RosettaAlias", "112-112-5132", 1 },
                    { 16, "Cathryn@bataillonMail.com", "Cathryn", "Kalvee", 0, "CathrynAlias", "158-845-1482", 1 },
                    { 14, "Adrian@bataillonMail.com", "Adrian", "Dragstrup", 0, "AdrianAlias", "185-557-2464", 1 },
                    { 3, "Sheryl@bataillonMail.com", "Sheryl", "Steinstrand", 0, "SherylAlias", "367-252-3834", 3 },
                    { 24, "Angelina@bataillonMail.com", "Angelina", "Lazmerge", 0, "AngelinaAlias", "375-615-6481", 3 },
                    { 26, "Jane@bataillonMail.com", "Jane", "Breksos", 0, "JaneAlias", "348-183-5427", 3 },
                    { 45, "Alejandro@bataillonMail.com", "Alejandro", "Jonkruojis", 0, "AlejandroAlias", "212-258-1157", 3 },
                    { 36, "Krissy@bataillonMail.com", "Krissy", "Hókrókur", 0, "KrissyAlias", "548-241-1545", 5 },
                    { 34, "Leida@bataillonMail.com", "Leida", "Nittinen", 0, "LeidaAlias", "475-753-2427", 5 },
                    { 13, "Ernestine@bataillonMail.com", "Ernestine", "Hókrókur", 0, "ErnestineAlias", "567-318-6851", 5 },
                    { 11, "Leida@bataillonMail.com", "Leida", "Kalatee", 0, "LeidaAlias", "414-822-7833", 5 },
                    { 5, "Berniece@bataillonMail.com", "Berniece", "Vadtälje", 0, "BernieceAlias", "333-648-2851", 5 },
                    { 97, "Adell@bataillonMail.com", "Adell", "Ulhus", 0, "AdellAlias", "435-313-3181", 4 },
                    { 95, "Dina@bataillonMail.com", "Dina", "Norrviken", 0, "DinaAlias", "362-715-4163", 4 },
                    { 76, "Bianca@bataillonMail.com", "Bianca", "Haapsa", 0, "BiancaAlias", "418-758-8543", 4 },
                    { 74, "Sherlene@bataillonMail.com", "Sherlene", "Lystrup", 0, "SherleneAlias", "454-352-1525", 4 },
                    { 72, "Berniece@bataillonMail.com", "Berniece", "Vadtälje", 0, "BernieceAlias", "381-864-2587", 4 },
                    { 98, "Pierre@bataillonMail.com", "Pierre", "Apatcruz", 0, "PierreAlias", "853-442-7514", 9 },
                    { 53, "Tyson@bataillonMail.com", "Tyson", "Ulhus", 0, "TysonAlias", "437-728-6157", 4 },
                    { 32, "Bianca@bataillonMail.com", "Bianca", "Mõisali", 0, "BiancaAlias", "422-465-2481", 4 },
                    { 30, "Adell@bataillonMail.com", "Adell", "Ulhus", 0, "AdellAlias", "456-877-3463", 4 },
                    { 28, "Dina@bataillonMail.com", "Dina", "Norrviken", 0, "DinaAlias", "313-571-4445", 4 },
                    { 4, "Mariella@bataillonMail.com", "Mariella", "Nuugaatrapaluk", 0, "MariellaAlias", "785-411-6446", 4 },
                    { 93, "Jane@bataillonMail.com", "Jane", "Breksos", 0, "JaneAlias", "317-427-5145", 3 },
                    { 91, "Marcie@bataillonMail.com", "Marcie", "Lazmerge", 0, "MarcieAlias", "354-831-6127", 3 },
                    { 70, "Sheryl@bataillonMail.com", "Sheryl", "Steinstrand", 0, "SherylAlias", "336-476-3561", 3 },
                    { 68, "Angelina@bataillonMail.com", "Angelina", "Jonkruojis", 0, "AngelinaAlias", "373-188-3543", 3 },
                    { 49, "Jane@bataillonMail.com", "Jane", "Breksos", 0, "JaneAlias", "321-134-7113", 3 },
                    { 47, "Marcie@bataillonMail.com", "Marcie", "Steinstrand", 0, "MarcieAlias", "355-546-8175", 3 },
                    { 51, "Sherlene@bataillonMail.com", "Sherlene", "Norrviken", 0, "SherleneAlias", "374-422-7131", 4 },
                    { 10, "Derick@bataillonMail.com", "Derick", "Guasabaro", 0, "DerickAlias", "877-663-4428", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_teams_CaptainId",
                table: "teams",
                column: "CaptainId");

            migrationBuilder.CreateIndex(
                name: "IX_games_TeamAttackerId",
                table: "games",
                column: "TeamAttackerId");

            migrationBuilder.CreateIndex(
                name: "IX_games_TeamDefendantId",
                table: "games",
                column: "TeamDefendantId");

            migrationBuilder.AddForeignKey(
                name: "FK_games_teams_TeamAttackerId",
                table: "games",
                column: "TeamAttackerId",
                principalTable: "teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_games_teams_TeamDefendantId",
                table: "games",
                column: "TeamDefendantId",
                principalTable: "teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_teams_players_CaptainId",
                table: "teams",
                column: "CaptainId",
                principalTable: "players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_games_teams_TeamAttackerId",
                table: "games");

            migrationBuilder.DropForeignKey(
                name: "FK_games_teams_TeamDefendantId",
                table: "games");

            migrationBuilder.DropForeignKey(
                name: "FK_teams_players_CaptainId",
                table: "teams");

            migrationBuilder.DropIndex(
                name: "IX_teams_CaptainId",
                table: "teams");

            migrationBuilder.DropIndex(
                name: "IX_games_TeamAttackerId",
                table: "games");

            migrationBuilder.DropIndex(
                name: "IX_games_TeamDefendantId",
                table: "games");

            migrationBuilder.DeleteData(
                table: "games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "players",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "teams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "teams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "teams",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "teams",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "CaptainId",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "TeamAttackerId",
                table: "games");

            migrationBuilder.DropColumn(
                name: "TeamDefendantId",
                table: "games");

            migrationBuilder.AddColumn<int>(
                name: "Captain",
                table: "teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamAttacker",
                table: "games",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamDefendant",
                table: "games",
                type: "int",
                nullable: true);
        }
    }
}
