using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chat",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DisplayName = table.Column<string>(type: "text", nullable: false),
                    LastMessage = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ImageCoverId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChatMember",
                columns: table => new
                {
                    ChatId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    NickName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMember", x => new { x.ChatId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ChatMember_Chat_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChatUser",
                columns: table => new
                {
                    ChatsId = table.Column<Guid>(type: "uuid", nullable: false),
                    MembersId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatUser", x => new { x.ChatsId, x.MembersId });
                    table.ForeignKey(
                        name: "FK_ChatUser_Chat_ChatsId",
                        column: x => x.ChatsId,
                        principalTable: "Chat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MessageType = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: false),
                    PostId = table.Column<Guid>(type: "uuid", nullable: true),
                    MediaId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Like",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    PostId = table.Column<Guid>(type: "uuid", nullable: true),
                    CommentId = table.Column<int>(type: "integer", nullable: true),
                    MessageId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Like", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Like_Comment_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    PostId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Phonenumber = table.Column<string>(type: "text", nullable: false),
                    DisplayName = table.Column<string>(type: "text", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Birthday = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsBlock = table.Column<bool>(type: "boolean", nullable: false),
                    RefreshToken = table.Column<string>(type: "text", nullable: true),
                    AvatarId = table.Column<Guid>(type: "uuid", nullable: true),
                    CoverPhotoId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Media_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Media",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_Media_CoverPhotoId",
                        column: x => x.CoverPhotoId,
                        principalTable: "Media",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MessageType = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ChatId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: false),
                    MediaId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Message_Chat_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Message_Media_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Media",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Message_User_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Redirect = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Target = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notification_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Post_User_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelationShip",
                columns: table => new
                {
                    UserId1 = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId2 = table.Column<Guid>(type: "uuid", nullable: false),
                    Relation = table.Column<int>(type: "integer", nullable: false),
                    User1Id = table.Column<Guid>(type: "uuid", nullable: false),
                    User2Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationShip", x => new { x.UserId1, x.UserId2 });
                    table.ForeignKey(
                        name: "FK_RelationShip_User_User1Id",
                        column: x => x.User1Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelationShip_User_User2Id",
                        column: x => x.User2Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "AvatarId", "Birthday", "CoverPhotoId", "DisplayName", "Email", "Gender", "IsBlock", "Password", "Phonenumber", "RefreshToken", "UserName" },
                values: new object[,]
                {
                    { new Guid("02c87600-332d-44c9-8faa-fca5f3232069"), "17th Floor", null, new DateTime(1997, 11, 19, 0, 0, 0, 0, DateTimeKind.Utc), null, "Tarrance Sans", "tsans29@delicious.com", 0, false, "", "+387 134 469 3559", "", "tsans29" },
                    { new Guid("04d21fe5-b169-49fe-a9f7-0e64dd09d79b"), "Room 254", null, new DateTime(1990, 11, 20, 0, 0, 0, 0, DateTimeKind.Utc), null, "Tanya Beney", "tbeney1n@slideshare.net", 1, false, "", "+93 805 555 6783", "", "tbeney1n" },
                    { new Guid("063d4c6d-87d0-445e-a149-3671a9029e75"), "Suite 95", null, new DateTime(1995, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), null, "Herbert Smooth", "hsmooth1b@gizmodo.com", 0, false, "", "+52 243 441 6891", "", "hsmooth1b" },
                    { new Guid("06954eb0-7965-416f-865b-ca37e839d176"), "14th Floor", null, new DateTime(1987, 2, 16, 0, 0, 0, 0, DateTimeKind.Utc), null, "Dee Lagadu", "dlagadu2k@independent.co.uk", 1, false, "", "+1 929 272 5138", "", "dlagadu2k" },
                    { new Guid("092f52a5-e2dd-4683-84fd-bc1e41d11024"), "3rd Floor", null, new DateTime(2000, 10, 13, 0, 0, 0, 0, DateTimeKind.Utc), null, "Marlena Bisatt", "mbisatt1c@bloomberg.com", 1, false, "", "+7 961 460 2271", "", "mbisatt1c" },
                    { new Guid("0a3f5497-63ce-4067-96e8-e8878a6b4046"), "Room 1240", null, new DateTime(2000, 2, 23, 0, 0, 0, 0, DateTimeKind.Utc), null, "Gasper Marien", "gmarieng@columbia.edu", 0, false, "", "+86 192 818 4804", "", "gmarieng" },
                    { new Guid("0c0aca91-45ba-4fd2-b417-f34ded926941"), "Room 1551", null, new DateTime(1996, 3, 24, 0, 0, 0, 0, DateTimeKind.Utc), null, "Cassandra Danick", "cdanick16@bravesites.com", 1, false, "", "+7 192 313 4831", "", "cdanick16" },
                    { new Guid("14f91ff2-5f6c-48e9-9c54-b9b8fec62ee4"), "Room 1897", null, new DateTime(2008, 2, 24, 0, 0, 0, 0, DateTimeKind.Utc), null, "Milicent Lavery", "mlaveryd@fastcompany.com", 1, false, "", "+47 200 531 0688", "", "mlaveryd" },
                    { new Guid("18089d60-1c80-40e3-90bb-070efa846968"), "PO Box 36056", null, new DateTime(1986, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), null, "Nickolai Crocetto", "ncrocetto22@nydailynews.com", 0, false, "", "+55 374 459 4021", "", "ncrocetto22" },
                    { new Guid("182d8d6b-28fc-4a34-82d8-d7a118037cbf"), "PO Box 23862", null, new DateTime(1995, 6, 21, 0, 0, 0, 0, DateTimeKind.Utc), null, "Ogdon Hindhaugh", "ohindhaugh1x@zimbio.com", 0, false, "", "+86 779 538 4975", "", "ohindhaugh1x" },
                    { new Guid("183fea4e-7f32-457e-ac17-dfc38edcc7c5"), "Room 1048", null, new DateTime(2007, 7, 15, 0, 0, 0, 0, DateTimeKind.Utc), null, "Brendin Espinho", "bespinho2e@zimbio.com", 0, false, "", "+84 301 980 4189", "", "bespinho2e" },
                    { new Guid("1c9360f8-ac1f-4f46-83cc-a0fb6fe70683"), "11th Floor", null, new DateTime(2006, 11, 13, 0, 0, 0, 0, DateTimeKind.Utc), null, "Paxon Pinnegar", "ppinnegarf@dropbox.com", 0, false, "", "+55 742 938 0535", "", "ppinnegarf" },
                    { new Guid("2046c2ff-ff04-4e49-ad7d-ad75c84fa99f"), "Apt 1825", null, new DateTime(2003, 7, 26, 0, 0, 0, 0, DateTimeKind.Utc), null, "Flint Hughf", "fhughf1g@blogger.com", 0, false, "", "+54 688 811 0111", "", "fhughf1g" },
                    { new Guid("2505e113-ee1c-46ce-adb4-b0a1910af932"), "Suite 10", null, new DateTime(2001, 7, 22, 0, 0, 0, 0, DateTimeKind.Utc), null, "Caitrin Fass", "cfassu@smugmug.com", 1, false, "", "+62 444 390 4281", "", "cfassu" },
                    { new Guid("26e718d8-3d45-437c-893f-9fd7458a3e25"), "Apt 624", null, new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, "Odette Hanscombe", "ohanscombe14@scientificamerican.com", 1, false, "", "+46 606 276 4004", "", "ohanscombe14" },
                    { new Guid("26fd5aa0-496f-4bef-96b6-59bb41cb636e"), "Suite 73", null, new DateTime(1996, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Toiboid Ferron", "tferronh@tamu.edu", 0, false, "", "+48 410 657 5879", "", "tferronh" },
                    { new Guid("2abdebbb-7b96-40b6-978a-c1e3b55d4460"), "Suite 15", null, new DateTime(1995, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), null, "Tabor Elloway", "tellowayv@umn.edu", 0, false, "", "+86 751 400 2866", "", "tellowayv" },
                    { new Guid("2bf7b3bc-80da-4b99-8478-f0fd99445f10"), "Room 280", null, new DateTime(1983, 10, 13, 0, 0, 0, 0, DateTimeKind.Utc), null, "Burton Lohan", "blohan2f@oracle.com", 0, false, "", "+86 484 290 1614", "", "blohan2f" },
                    { new Guid("2c8632eb-189d-4ab4-b3e9-8dcae96df7e9"), "PO Box 52305", null, new DateTime(1986, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), null, "Clair Grimsdyke", "cgrimsdykeo@example.com", 0, false, "", "+86 284 638 5779", "", "cgrimsdykeo" },
                    { new Guid("2ce3b1b8-e433-4700-93ae-b0cb992d6a02"), "Room 629", null, new DateTime(2007, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), null, "Susan Ferras", "sferras27@miitbeian.gov.cn", 1, false, "", "+63 565 382 1877", "", "sferras27" },
                    { new Guid("31ad0b31-3b4e-471b-892f-b10a5b2b00a5"), "19th Floor", null, new DateTime(1987, 6, 19, 0, 0, 0, 0, DateTimeKind.Utc), null, "Che Steeples", "csteeples13@reuters.com", 1, false, "", "+86 963 339 5732", "", "csteeples13" },
                    { new Guid("33e04aa4-e275-411e-b0b7-21254d0ec7b9"), "PO Box 86697", null, new DateTime(1999, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), null, "Paulie Duckfield", "pduckfield1y@microsoft.com", 0, false, "", "+33 777 268 1515", "", "pduckfield1y" },
                    { new Guid("390ae664-4c28-41d1-b73c-e1b46887300e"), "Room 379", null, new DateTime(2007, 4, 27, 0, 0, 0, 0, DateTimeKind.Utc), null, "Martino Hamill", "mhamill2j@xing.com", 0, false, "", "+33 704 414 5928", "", "mhamill2j" },
                    { new Guid("395bec8f-a363-4b9b-9130-9faabbc7030a"), "Apt 99", null, new DateTime(1996, 3, 25, 0, 0, 0, 0, DateTimeKind.Utc), null, "Marya Leall", "mleallm@addtoany.com", 1, false, "", "+7 161 251 3077", "", "mleallm" },
                    { new Guid("3cf9393e-214e-449d-a796-aef4f22f27be"), "PO Box 51977", null, new DateTime(2008, 11, 7, 0, 0, 0, 0, DateTimeKind.Utc), null, "Gabriel Ruvel", "gruvelk@cam.ac.uk", 1, false, "", "+62 873 428 9886", "", "gruvelk" },
                    { new Guid("4440f9b3-e64d-46de-928c-3b9a1812f319"), "Suite 38", null, new DateTime(2003, 5, 8, 0, 0, 0, 0, DateTimeKind.Utc), null, "Miran Di Giacomo", "mdi1d@gov.uk", 1, false, "", "+63 298 301 0165", "", "mdi1d" },
                    { new Guid("4595c478-9f7e-4828-a106-c6106cb5230b"), "Suite 79", null, new DateTime(1989, 10, 17, 0, 0, 0, 0, DateTimeKind.Utc), null, "Dalia Brisse", "dbrisse2i@mail.ru", 1, false, "", "+7 292 805 6250", "", "dbrisse2i" },
                    { new Guid("45fe4a09-51ab-4d57-8e95-ae42d98a8e65"), "Room 1388", null, new DateTime(1988, 5, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, "Emili Radbond", "eradbond1z@mit.edu", 1, false, "", "+51 628 717 1060", "", "eradbond1z" },
                    { new Guid("48537e57-b5d9-4973-8734-5c7934d6d5bd"), "19th Floor", null, new DateTime(1993, 11, 14, 0, 0, 0, 0, DateTimeKind.Utc), null, "Zedekiah Anglim", "zanglim1s@w3.org", 0, false, "", "+81 819 881 8979", "", "zanglim1s" },
                    { new Guid("4e5d891d-773a-4462-8bdf-296f153aecc8"), "9th Floor", null, new DateTime(2009, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc), null, "Maris McKew", "mmckew15@cpanel.net", 1, false, "", "+62 243 987 9010", "", "mmckew15" },
                    { new Guid("51493e94-1f18-4a1f-aefb-8c86b840cbf3"), "17th Floor", null, new DateTime(1990, 2, 21, 0, 0, 0, 0, DateTimeKind.Utc), null, "Shurlock Provest", "sprovest1h@google.de", 0, false, "", "+62 436 581 8351", "", "sprovest1h" },
                    { new Guid("5190615c-625a-448f-9349-c1edae6e40bb"), "Apt 1780", null, new DateTime(1998, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), null, "Layton Sutcliff", "lsutcliffi@nbcnews.com", 0, false, "", "+86 806 514 6703", "", "lsutcliffi" },
                    { new Guid("53e3224d-40ca-423c-85cb-0908aed68558"), "8th Floor", null, new DateTime(1999, 9, 21, 0, 0, 0, 0, DateTimeKind.Utc), null, "Eva Stag", "estagl@cdbaby.com", 1, false, "", "+86 824 914 9036", "", "estagl" },
                    { new Guid("5d8077a9-09cd-47d6-bea5-ac77fddddc52"), "Suite 73", null, new DateTime(2004, 8, 27, 0, 0, 0, 0, DateTimeKind.Utc), null, "Avrom Ekell", "aekell8@dion.ne.jp", 0, false, "", "+359 394 533 3016", "", "aekell8" },
                    { new Guid("5ed2bbaf-6368-4795-bf3d-a2bc81fae3f1"), "Apt 1586", null, new DateTime(1999, 10, 25, 0, 0, 0, 0, DateTimeKind.Utc), null, "Phineas Cummins", "pcummins25@craigslist.org", 0, false, "", "+63 651 830 9069", "", "pcummins25" },
                    { new Guid("63115aeb-18c7-4871-bdf8-a25057c56cee"), "PO Box 27189", null, new DateTime(1997, 6, 18, 0, 0, 0, 0, DateTimeKind.Utc), null, "Iago Pennazzi", "ipennazzi1q@acquirethisname.com", 0, false, "", "+84 255 358 5970", "", "ipennazzi1q" },
                    { new Guid("6349259d-3aea-464b-b88e-5e6e2ad792fb"), "Suite 90", null, new DateTime(1994, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), null, "Hannis Duchenne", "hduchenne2g@mit.edu", 1, false, "", "+86 883 971 0140", "", "hduchenne2g" },
                    { new Guid("678f479b-f803-4183-811c-b50236251d09"), "PO Box 66928", null, new DateTime(1989, 2, 13, 0, 0, 0, 0, DateTimeKind.Utc), null, "Patrizio Ossulton", "possulton2l@ow.ly", 0, false, "", "+502 562 498 8408", "", "possulton2l" },
                    { new Guid("685fbf2e-ea19-4c46-bf6e-61528a949d0e"), "Suite 68", null, new DateTime(1998, 5, 23, 0, 0, 0, 0, DateTimeKind.Utc), null, "Nikolaus Renish", "nrenish1@xing.com", 0, false, "", "+62 571 701 4868", "", "nrenish1" },
                    { new Guid("6cae73f1-aab4-4174-a5ed-cd522fb75dc5"), "Room 1257", null, new DateTime(1982, 4, 27, 0, 0, 0, 0, DateTimeKind.Utc), null, "Jennifer Fountaine", "jfountaine1i@nifty.com", 1, false, "", "+86 140 511 4550", "", "jfountaine1i" },
                    { new Guid("6f0bebb6-ea5e-48f1-8c7b-e4532fe6002a"), "Suite 8", null, new DateTime(1989, 10, 6, 0, 0, 0, 0, DateTimeKind.Utc), null, "Darrel Hodgets", "dhodgets1a@indiegogo.com", 0, false, "", "+62 912 164 9763", "", "dhodgets1a" },
                    { new Guid("711cf0e2-8eb6-487b-a811-1a31e5fe85fd"), "Apt 660", null, new DateTime(2001, 3, 17, 0, 0, 0, 0, DateTimeKind.Utc), null, "Geno Houliston", "ghoulistonp@free.fr", 0, false, "", "+381 399 927 7606", "", "ghoulistonp" },
                    { new Guid("74db699c-2a05-455d-b250-d2222bf08ef3"), "Room 1137", null, new DateTime(2003, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, "Lucia Hoonahan", "lhoonahan0@about.com", 1, false, "", "+86 300 494 5588", "", "lhoonahan0" },
                    { new Guid("7593015b-da4d-4c4f-a0fe-060e0580ffdc"), "Suite 59", null, new DateTime(2006, 11, 13, 0, 0, 0, 0, DateTimeKind.Utc), null, "Mackenzie Knellen", "mknellenq@dmoz.org", 0, false, "", "+81 410 501 7491", "", "mknellenq" },
                    { new Guid("75c88dd2-4897-453b-8a87-e6b2f92a8c56"), "PO Box 43206", null, new DateTime(2010, 10, 29, 0, 0, 0, 0, DateTimeKind.Utc), null, "Jeanne Gyver", "jgyver2n@skyrock.com", 0, false, "", "+66 966 304 1461", "", "jgyver2n" },
                    { new Guid("75e4399e-7dde-48b2-a97d-10477b902592"), "Apt 262", null, new DateTime(1996, 11, 18, 0, 0, 0, 0, DateTimeKind.Utc), null, "Rebekah Harbisher", "rharbisher2a@mapquest.com", 1, false, "", "+27 472 646 0728", "", "rharbisher2a" },
                    { new Guid("7c057638-7d54-4267-afe5-dbe4ff47eb58"), "Apt 927", null, new DateTime(1991, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), null, "Gerek Luckes", "gluckes1j@senate.gov", 0, false, "", "+62 822 689 1861", "", "gluckes1j" },
                    { new Guid("7eee451e-d38c-43f1-b823-899aee943a23"), "Suite 30", null, new DateTime(2000, 5, 14, 0, 0, 0, 0, DateTimeKind.Utc), null, "Lydon Oldroyde", "loldroydex@1688.com", 0, false, "", "+92 218 551 3914", "", "loldroydex" },
                    { new Guid("8038716b-0165-4c0b-a5e7-d9668c424645"), "PO Box 94863", null, new DateTime(1996, 6, 18, 0, 0, 0, 0, DateTimeKind.Utc), null, "Atalanta Reglar", "areglare@illinois.edu", 1, false, "", "+62 573 904 8222", "", "areglare" },
                    { new Guid("80842ce0-f3af-4fd2-9cbb-657da3e071ea"), "14th Floor", null, new DateTime(1993, 9, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, "Esteban Saywell", "esaywell1m@plala.or.jp", 0, false, "", "+86 464 845 6785", "", "esaywell1m" },
                    { new Guid("88a10def-f37e-4864-b6dc-da950659d42e"), "12th Floor", null, new DateTime(2003, 8, 22, 0, 0, 0, 0, DateTimeKind.Utc), null, "Eben Durning", "edurning2h@cbslocal.com", 0, false, "", "+62 120 600 4007", "", "edurning2h" },
                    { new Guid("89ff4f67-0589-4961-8371-abd7cee63728"), "Suite 4", null, new DateTime(1995, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), null, "Yolanda Korting", "ykortingr@wikispaces.com", 1, false, "", "+351 780 597 3423", "", "ykortingr" },
                    { new Guid("913381bb-f584-4b8d-9c4c-8d99bae41f94"), "PO Box 2439", null, new DateTime(1999, 4, 13, 0, 0, 0, 0, DateTimeKind.Utc), null, "Sherlocke Lowater", "slowatern@clickbank.net", 0, false, "", "+62 479 865 7435", "", "slowatern" },
                    { new Guid("93773cf6-4e19-4f06-bdfb-15b20f805891"), "Room 330", null, new DateTime(1992, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), null, "Jacenta Mansion", "jmansiony@stanford.edu", 1, false, "", "+62 140 338 5498", "", "jmansiony" },
                    { new Guid("9383ea72-e7a7-4636-b741-529e85bfb417"), "PO Box 6255", null, new DateTime(2001, 4, 14, 0, 0, 0, 0, DateTimeKind.Utc), null, "Lennard Blissitt", "lblissittz@cnn.com", 0, false, "", "+86 847 599 0102", "", "lblissittz" },
                    { new Guid("93fc0f14-479e-4ea1-8be2-1fa2a4908173"), "Suite 97", null, new DateTime(1981, 4, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, "Berke Winpenny", "bwinpenny4@apple.com", 0, false, "", "+63 589 534 6421", "", "bwinpenny4" },
                    { new Guid("94ccbdce-4ad5-4595-9980-8b5b06ff9bb2"), "10th Floor", null, new DateTime(2005, 8, 17, 0, 0, 0, 0, DateTimeKind.Utc), null, "Kathlin Carnow", "kcarnow20@ox.ac.uk", 1, false, "", "+33 107 228 2828", "", "kcarnow20" },
                    { new Guid("96aa849d-09eb-437e-94e5-fc0f9f67bf56"), "Apt 231", null, new DateTime(1992, 5, 31, 0, 0, 0, 0, DateTimeKind.Utc), null, "Basia Winny", "bwinny6@cisco.com", 1, false, "", "+234 872 112 9439", "", "bwinny6" },
                    { new Guid("98298a15-8d3c-4baf-a9e9-04e936f90530"), "Room 1376", null, new DateTime(1997, 7, 14, 0, 0, 0, 0, DateTimeKind.Utc), null, "Glynda Hacaud", "ghacaud3@walmart.com", 1, false, "", "+7 123 481 5931", "", "ghacaud3" },
                    { new Guid("982a5c9f-07b6-46a1-aa98-d6de5db3ed7b"), "Apt 1846", null, new DateTime(2005, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc), null, "Rhodia Davidi", "rdavidi24@unblog.fr", 1, false, "", "+63 960 493 0562", "", "rdavidi24" },
                    { new Guid("9bccd2d2-c8b7-4b91-a032-2ddb8cdb94c5"), "PO Box 26645", null, new DateTime(1982, 5, 30, 0, 0, 0, 0, DateTimeKind.Utc), null, "Noland Crosfield", "ncrosfield2p@mayoclinic.com", 0, false, "", "+1 214 266 7530", "", "ncrosfield2p" },
                    { new Guid("a553ea19-61f9-475a-b4d1-e28d32877c4d"), "Room 1290", null, new DateTime(1999, 4, 7, 0, 0, 0, 0, DateTimeKind.Utc), null, "Mozes Hadrill", "mhadrill11@csmonitor.com", 0, false, "", "+55 150 897 1287", "", "mhadrill11" },
                    { new Guid("a99d3d57-c3fc-43e6-bf86-f399f1d6095b"), "Suite 50", null, new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), null, "Gertie Stile", "gstile18@studiopress.com", 1, false, "", "+1 323 215 8229", "", "gstile18" },
                    { new Guid("aa591b01-f649-4510-8fad-80bcbe15362b"), "Room 675", null, new DateTime(2009, 2, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, "Brittney Holtom", "bholtomj@miitbeian.gov.cn", 1, false, "", "+48 434 166 5456", "", "bholtomj" },
                    { new Guid("ab280826-c238-4060-b33f-e5e4e65181a7"), "5th Floor", null, new DateTime(1991, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), null, "Corabel Weerdenburg", "cweerdenburg1v@statcounter.com", 1, false, "", "+33 186 970 4221", "", "cweerdenburg1v" },
                    { new Guid("ae7c3960-7949-4354-83af-c5c0196cd386"), "PO Box 90561", null, new DateTime(1998, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), null, "Arri Brittain", "abrittain1f@sitemeter.com", 0, false, "", "+20 583 926 7348", "", "abrittain1f" },
                    { new Guid("b1206d33-83b6-4f6d-b35a-f7037ad9fcf8"), "Apt 41", null, new DateTime(1980, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), null, "Jessamyn Masi", "jmasic@technorati.com", 1, false, "", "+54 145 835 4156", "", "jmasic" },
                    { new Guid("b293c706-f6b9-4d2a-b647-72ade76803c7"), "Suite 19", null, new DateTime(1995, 4, 14, 0, 0, 0, 0, DateTimeKind.Utc), null, "Thayne McKennan", "tmckennan2b@wufoo.com", 0, false, "", "+63 119 604 8230", "", "tmckennan2b" },
                    { new Guid("b5a702f0-88ae-4c89-a9ef-4802fc812726"), "Suite 47", null, new DateTime(2009, 7, 16, 0, 0, 0, 0, DateTimeKind.Utc), null, "Sybille Harly", "sharly17@foxnews.com", 1, false, "", "+1 921 953 8511", "", "sharly17" },
                    { new Guid("b86478e4-9a1e-4362-a51e-30c539151884"), "Apt 81", null, new DateTime(1981, 11, 21, 0, 0, 0, 0, DateTimeKind.Utc), null, "Desiri Assiratti", "dassiratti2o@boston.com", 1, false, "", "+353 619 790 4818", "", "dassiratti2o" },
                    { new Guid("bac7715e-2030-4245-89c5-98e9316c9622"), "Suite 26", null, new DateTime(1980, 2, 16, 0, 0, 0, 0, DateTimeKind.Utc), null, "Marci Caren", "mcaren1r@boston.com", 1, false, "", "+1 775 488 0749", "", "mcaren1r" },
                    { new Guid("c050f59c-192f-440b-9d98-11e9003db9fd"), "Room 354", null, new DateTime(1984, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), null, "Randell Rookes", "rrookes10@1und1.de", 0, false, "", "+86 588 961 3952", "", "rrookes10" },
                    { new Guid("c2b221a0-7efb-4f8a-bcc3-3fe1cef13d3a"), "Apt 1593", null, new DateTime(1989, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc), null, "Eugen Mingaye", "emingaye2r@google.es", 0, false, "", "+1 216 114 7742", "", "emingaye2r" },
                    { new Guid("c3c62964-d8f4-49db-b336-c14377c73f9d"), "2nd Floor", null, new DateTime(1995, 8, 8, 0, 0, 0, 0, DateTimeKind.Utc), null, "Tomkin Whyborne", "twhyborne19@cnn.com", 0, false, "", "+1 303 573 3210", "", "twhyborne19" },
                    { new Guid("cab2c230-22df-488b-bf8b-4057b2931063"), "Suite 70", null, new DateTime(1983, 8, 10, 0, 0, 0, 0, DateTimeKind.Utc), null, "Felicity Berger", "fberger9@wikia.com", 1, false, "", "+33 558 260 3689", "", "fberger9" },
                    { new Guid("cb16687f-6d27-4859-8e5f-44a57600f55e"), "Suite 7", null, new DateTime(1999, 7, 12, 0, 0, 0, 0, DateTimeKind.Utc), null, "Merell Ivanyushin", "mivanyushin1t@sbwire.com", 0, false, "", "+86 931 881 5172", "", "mivanyushin1t" },
                    { new Guid("d0b752a4-2364-44f8-a53f-e971441fe1c1"), "Room 669", null, new DateTime(1986, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc), null, "Rosalyn Goodee", "rgoodeea@bloomberg.com", 1, false, "", "+86 954 209 1325", "", "rgoodeea" },
                    { new Guid("d371c7ad-c689-4335-b38e-bf634e1a632e"), "16th Floor", null, new DateTime(2000, 9, 27, 0, 0, 0, 0, DateTimeKind.Utc), null, "Trenton Gisburn", "tgisburn23@wordpress.org", 0, false, "", "+86 589 185 4668", "", "tgisburn23" },
                    { new Guid("d38ee58a-9e2c-4223-aa3b-e7ee32fdf0f1"), "Room 1478", null, new DateTime(2007, 8, 6, 0, 0, 0, 0, DateTimeKind.Utc), null, "Sorcha Buxam", "sbuxam2d@ifeng.com", 1, false, "", "+51 739 742 4507", "", "sbuxam2d" },
                    { new Guid("d9404d45-5418-4a77-bf1f-2cf37b3ebfc3"), "Suite 31", null, new DateTime(2002, 10, 13, 0, 0, 0, 0, DateTimeKind.Utc), null, "Kearney Rean", "kreans@wunderground.com", 0, false, "", "+63 754 718 0421", "", "kreans" },
                    { new Guid("db16d5c1-8259-4b98-ab76-8f7e836ac496"), "PO Box 69627", null, new DateTime(1985, 7, 8, 0, 0, 0, 0, DateTimeKind.Utc), null, "Mortimer Griffith", "mgriffith1p@auda.org.au", 0, false, "", "+86 538 268 2153", "", "mgriffith1p" },
                    { new Guid("dc8263fc-0493-485a-aced-b490473e46ca"), "PO Box 86531", null, new DateTime(1991, 8, 16, 0, 0, 0, 0, DateTimeKind.Utc), null, "Ulric Clamo", "uclamo2@google.it", 0, false, "", "+225 789 424 7730", "", "uclamo2" },
                    { new Guid("dcc2352e-71d0-45c7-9ea7-cff93bc8eec1"), "PO Box 1316", null, new DateTime(2010, 5, 7, 0, 0, 0, 0, DateTimeKind.Utc), null, "Tuckie Waddingham", "twaddingham1l@state.tx.us", 0, false, "", "+48 460 879 7856", "", "twaddingham1l" },
                    { new Guid("dd76a605-11f5-46be-8ae4-57207aedd42e"), "Apt 1883", null, new DateTime(2005, 3, 8, 0, 0, 0, 0, DateTimeKind.Utc), null, "Byrom Hooban", "bhooban12@noaa.gov", 0, false, "", "+52 339 266 6510", "", "bhooban12" },
                    { new Guid("df3bfb94-8280-4b94-805c-43c12873a3b2"), "Suite 68", null, new DateTime(2004, 4, 3, 0, 0, 0, 0, DateTimeKind.Utc), null, "Marja Melson", "mmelson2c@free.fr", 1, false, "", "+221 146 447 5591", "", "mmelson2c" },
                    { new Guid("e792d3be-83d6-4ea1-8a8c-c14d69b7bd3a"), "Room 233", null, new DateTime(1983, 1, 3, 0, 0, 0, 0, DateTimeKind.Utc), null, "Ardene Mudd", "amudd1w@paypal.com", 1, false, "", "+86 986 432 3434", "", "amudd1w" },
                    { new Guid("e80d101e-a0f4-4ce5-850c-4357d8abdc2e"), "PO Box 27159", null, new DateTime(1986, 12, 27, 0, 0, 0, 0, DateTimeKind.Utc), null, "Vincenty Denzilow", "vdenzilow21@elegantthemes.com", 0, false, "", "+86 894 860 3333", "", "vdenzilow21" },
                    { new Guid("e9d26936-1503-4d68-b1a8-640374b85c38"), "Apt 1196", null, new DateTime(1984, 7, 15, 0, 0, 0, 0, DateTimeKind.Utc), null, "Caroline Rhead", "crhead2m@nytimes.com", 1, false, "", "+62 668 105 8368", "", "crhead2m" },
                    { new Guid("edee5ac6-8fc1-42f2-a8b2-437625d87976"), "14th Floor", null, new DateTime(2000, 6, 23, 0, 0, 0, 0, DateTimeKind.Utc), null, "Emeline Siggery", "esiggery7@fc2.com", 1, false, "", "+86 825 991 0078", "", "esiggery7" },
                    { new Guid("ef83ae2a-25e5-4587-a5ac-96a0ae5e7a39"), "Suite 91", null, new DateTime(2009, 2, 10, 0, 0, 0, 0, DateTimeKind.Utc), null, "Milt Dacre", "mdacre5@elpais.com", 0, false, "", "+55 108 859 9235", "", "mdacre5" },
                    { new Guid("f044c485-427f-4d94-9c58-3267a85fe82b"), "PO Box 43205", null, new DateTime(1985, 12, 29, 0, 0, 0, 0, DateTimeKind.Utc), null, "Cami Evershed", "cevershed1k@cargocollective.com", 1, false, "", "+7 881 914 0088", "", "cevershed1k" },
                    { new Guid("f10108ba-9b48-4815-8d14-441e8f6dbe05"), "Room 1783", null, new DateTime(1982, 4, 15, 0, 0, 0, 0, DateTimeKind.Utc), null, "Sindee Queyos", "squeyos1e@berkeley.edu", 1, false, "", "+257 107 131 9355", "", "squeyos1e" },
                    { new Guid("f2f9ce59-fea9-4164-b7d3-241088217ca1"), "4th Floor", null, new DateTime(1996, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc), null, "Wylma Fisby", "wfisbyb@paginegialle.it", 1, false, "", "+57 751 674 5993", "", "wfisbyb" },
                    { new Guid("f4fabeeb-9e87-411b-b864-8fc90d66d245"), "Room 930", null, new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Utc), null, "Ragnar Fairlaw", "rfairlaw1u@statcounter.com", 0, false, "", "+593 213 988 7999", "", "rfairlaw1u" },
                    { new Guid("f818bf66-266f-4189-9883-6b936b871c71"), "Suite 80", null, new DateTime(2009, 3, 6, 0, 0, 0, 0, DateTimeKind.Utc), null, "Thedrick Ludee", "tludee26@merriam-webster.com", 0, false, "", "+49 744 381 3187", "", "tludee26" },
                    { new Guid("f8a54586-5089-425f-a686-0bb3ee52a774"), "PO Box 38947", null, new DateTime(1981, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc), null, "Dianna Marjot", "dmarjot28@naver.com", 1, false, "", "+56 311 922 2790", "", "dmarjot28" },
                    { new Guid("f8dba2f9-5607-4f9a-abed-92a3306b88d5"), "Suite 10", null, new DateTime(1989, 7, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Blakelee Hindmoor", "bhindmoort@intel.com", 1, false, "", "+33 486 310 5537", "", "bhindmoort" },
                    { new Guid("f957f63b-d317-42a7-8080-e317829f6b3a"), "Room 211", null, new DateTime(1996, 5, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, "Theodoric Cartmel", "tcartmelw@wix.com", 0, false, "", "+1 716 592 5014", "", "tcartmelw" },
                    { new Guid("fd3f77f9-1ae6-43cd-bb85-e379bebb85cd"), "PO Box 65263", null, new DateTime(1998, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Kelly Crux", "kcrux1o@nyu.edu", 0, false, "", "+55 670 213 2116", "", "kcrux1o" },
                    { new Guid("fda8cb18-52c5-413f-b0f0-0a3dc600d28d"), "Room 206", null, new DateTime(1995, 8, 16, 0, 0, 0, 0, DateTimeKind.Utc), null, "Thorny Brandino", "tbrandino2q@nps.gov", 0, false, "", "+48 780 793 5631", "", "tbrandino2q" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chat_ImageCoverId",
                table: "Chat",
                column: "ImageCoverId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMember_UserId",
                table: "ChatMember",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatUser_MembersId",
                table: "ChatUser",
                column: "MembersId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_CreatorId",
                table: "Comment",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_MediaId",
                table: "Comment",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_PostId",
                table: "Comment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Like_CommentId",
                table: "Like",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Like_MessageId",
                table: "Like",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Like_PostId",
                table: "Like",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Like_UserId",
                table: "Like",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_PostId",
                table: "Media",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_ChatId",
                table: "Message",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_CreatorId",
                table: "Message",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_MediaId",
                table: "Message",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_UserId",
                table: "Notification",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_CreatorId",
                table: "Post",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_RelationShip_User1Id",
                table: "RelationShip",
                column: "User1Id");

            migrationBuilder.CreateIndex(
                name: "IX_RelationShip_User2Id",
                table: "RelationShip",
                column: "User2Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_AvatarId",
                table: "User",
                column: "AvatarId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CoverPhotoId",
                table: "User",
                column: "CoverPhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chat_Media_ImageCoverId",
                table: "Chat",
                column: "ImageCoverId",
                principalTable: "Media",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMember_User_UserId",
                table: "ChatMember",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatUser_User_MembersId",
                table: "ChatUser",
                column: "MembersId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Media_MediaId",
                table: "Comment",
                column: "MediaId",
                principalTable: "Media",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Post_PostId",
                table: "Comment",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_User_CreatorId",
                table: "Comment",
                column: "CreatorId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Like_Message_MessageId",
                table: "Like",
                column: "MessageId",
                principalTable: "Message",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Like_Post_PostId",
                table: "Like",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Like_User_UserId",
                table: "Like",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Media_Post_PostId",
                table: "Media",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Media_AvatarId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Media_CoverPhotoId",
                table: "User");

            migrationBuilder.DropTable(
                name: "ChatMember");

            migrationBuilder.DropTable(
                name: "ChatUser");

            migrationBuilder.DropTable(
                name: "Like");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "RelationShip");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "Chat");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
