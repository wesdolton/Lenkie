using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LenkieWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class makeReturndateNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnDate",
                table: "BorrowedBooks",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "ShortDescription",
                value: "Unravel the mysteries of a celestial library where stories transcend space and time. Chronicles of the Celestial Scribe weaves a tapestry of cosmic adventures, where a humble scribe holds the key to unlocking the boundless tales of the universe, each word etching the destiny of worlds yet unknown.");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "ShortDescription",
                value: "Venture into the quantum frontier where reality blurs and possibilities multiply. Quantum Paradox explores a world where science collides with the surreal, and choices create branching timelines. As the protagonist grapples with the consequences of their decisions, a mind-bending adventure unfolds across the multiverse.");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "ShortDescription",
                value: "Amidst the mystical mists of Azurea, a forgotten prophecy stirs the winds of change. Mists of Azurea unfolds the tale of a reluctant hero, chosen by ancient forces, as they navigate a realm where illusions dance and destinies intertwine. Will they unravel the secrets veiled in the ethereal mist?");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "ShortDescription",
                value: "Dive into a world where music is magic and melodies hold the power to shape reality. Ephemeral Symphony follows the journey of a young prodigy navigating the harmonious landscapes of a city that resonates with enchanting tunes. A symphony of love, loss, and the transcendent notes that echo through the ages.");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                column: "ShortDescription",
                value: "In a realm where ancient magic collides with the technological wonders of tomorrow, a reluctant hero discovers a hidden legacy. Whispers of the Forgotten invites readers on an epic journey through forgotten cities and forbidden realms, where secrets buried in time awaken to reshape destinies.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnDate",
                table: "BorrowedBooks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "ShortDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "ShortDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "ShortDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "ShortDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                column: "ShortDescription",
                value: null);
        }
    }
}
