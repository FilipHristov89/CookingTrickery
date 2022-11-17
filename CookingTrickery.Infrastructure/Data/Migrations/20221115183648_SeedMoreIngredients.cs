using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookingTrickery.Infrastructure.Data.Migrations
{
    public partial class SeedMoreIngredients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0093ae6c-d848-43bf-bc62-01c5e684f4a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8dd777e-d87e-4ccb-a944-49291c143bb5", "AQAAAAEAACcQAAAAEHNdtfIBKB9lTVcIa/tXpSNV1Ze54iYG9u9zHh1rrnFd8k9MPs+xo2ufl/3L80uPdw==", "ae2c9a8d-ad62-4cfc-b2b3-e7625b070865" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc60d5f7-3884-42c6-9fb5-e1db55094536",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39199cbc-5f5a-443c-83f5-9f9c555d250c", "AQAAAAEAACcQAAAAELJ8jeuzZuzrznsXPjYs00pb/sxdPUHSdK4Kqosh93JDrIOghOUAGuQenteA48tFxg==", "e1fa660f-e9de-47a7-8325-d1643aaf087b" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("52a20631-47f3-45c7-a1fe-a41802908375"),
                column: "Type",
                value: 10);

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Calories", "Description", "ImageUrl", "Name", "Origin", "Type" },
                values: new object[,]
                {
                    { new Guid("072818d1-6852-473a-b27b-803559c2de35"), 0, "Milk is a white liquid food produced by the mammary glands of mammals. It is the primary source of nutrition for young mammals (including breastfed human infants) before they are able to digest solid food Immune factors and immune-modulating components in milk contribute to milk immunity.", "https://solidstarts.com/wp-content/uploads/Milk-for-Babies-480x320.webp", "Milk", "All over the world", 7 },
                    { new Guid("07a09f60-233b-4ff3-bf95-b702917ae703"), 0, "Squid Ink is a dark-coloured or luminous ink released into water by most species of cephalopod, usually as an escape mechanism. Modern use of cephalopod ink is generally limited to cooking, primarily in Japan and the Mediterranean, where it is used as a food colouring and flavouring, for example in pasta and sauces, and calamares en su tinta.", "https://chgojohn.files.wordpress.com/2015/12/squid-ink.jpg", "Squid Ink", "Ocean", 16 },
                    { new Guid("0add8fdc-b4d9-4ea6-bc0b-89d0801d204e"), 0, "Honey is a sweet and viscous substance made by several bees, the best-known of which are honey bees.Honey is made and stored to nourish bee colonies. Bees produce honey by gathering and then refining the sugary secretions of plants (primarily floral nectar) or the secretions of other insects, like the honeydew of aphids.", "https://5.imimg.com/data5/YH/RH/MY-43324479/natural-honey-1000x1000.jpg", "Honey", "All over the world", 24 },
                    { new Guid("0d4d9a46-26f5-4ec4-872a-80afae65b2b2"), 0, "Linguine sometimes anglicized as linguini is a type of pasta similar to fettuccine and trenette but elliptical in section rather than flat.", "https://upload.wikimedia.org/wikipedia/commons/d/da/Linguine.jpg", "Linguine", "Italy", 15 },
                    { new Guid("2b4a94a0-0693-4b75-9667-a57cdf3d576e"), 0, "Cream fresh is a dairy product, a soured cream containing 10–45% butterfat, with a pH of approximately 4.5. It is soured with a bacterial culture.", "https://images.immediate.co.uk/production/volatile/sites/30/2020/02/parmesan-00f8b31.jpg?quality=90&webp=true&resize=300,272", "Cream fresh", "France", 9 },
                    { new Guid("38ff0d4d-96df-4f76-9735-4510801e721b"), 0, "rborio rice is an Italian short-grain rice. It is named after the town of Arborio, in the Po Valley, which is situated in the region of Piedmont in Italy. When cooked, the rounded grains are firm, and creamy and chewy compared to other varieties of rice, due to their higher amylopectin starch content It has a starchy taste and blends well with other flavours.", "https://cdn.apartmenttherapy.info/image/upload/f_auto,q_auto:eco,c_fill,g_center,w_730,h_487/k%2FPhoto%2FSeries%2F2021-03-rice-o-pedia%2FArborio-Rice%2F2021-03-30_ATK-48176-Rice-Arborio", "Arborio rice", "Italy", 23 },
                    { new Guid("47b234b1-5a56-4c29-a0ff-73994c4175d3"), 47, "An orange is a fruit of various citrus species in the family Rutaceae it primarily refers to Citrus × sinensis, which is also called sweet orange, to distinguish it from the related Citrus × aurantium, referred to as bitter orange.", "https://www.santosfood.com/wp-content/uploads/2020/01/img-7.jpg?1742x1295", "Orange", "China", 12 },
                    { new Guid("63cd1418-5533-4056-a82e-61d1cba11370"), 0, "Parmesan (Italian: Parmigiano Reggiano; Italian pronunciation: [parmiˈdʒaːno redˈdʒaːno]) is an Italian hard, granular cheese produced from cows’ milk and aged at least 12 months.", "https://images.immediate.co.uk/production/volatile/sites/30/2020/02/parmesan-00f8b31.jpg?quality=90&webp=true&resize=300,272", "Parmesan", "Italy", 8 },
                    { new Guid("653294cb-c5fd-4c51-a470-25854918fb9d"), 0, "Merguez s a red, spicy mutton- or beef-based fresh sausage in Maghrebi cuisine.[1][2] Since the late 20th century, it has been popular in France and Great Britain due to the large Algerian populations", "https://thegourmetgoatfarmer.co.uk/wp-content/uploads/2021/01/Merguez-Sausages-600x461.jpg", "Merguez", "Africa", 14 },
                    { new Guid("7e7b0452-876f-428c-b56c-61c13663e629"), 0, "Water is an inorganic, transparent, tasteless, odorless, and nearly colorless chemical substance, which is the main constituent of Earth's hydrosphere and the fluids of all known living organisms. It is vital for all known forms of life, despite providing neither food, energy, nor organic micronutrients", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5e/Water_drop_001.jpg/1920px-Water_drop_001.jpg", "Water", "All over the world", 26 },
                    { new Guid("88bb61fd-478a-4431-ba19-3b45230656eb"), 0, "Peas are annual plants, with a life cycle of one year. They are a cool-season crop grown in many parts of the world, planting can take place from winter to early summer depending on location. The average pea weighs between 0.1 and 0.36 gram.The immature peas (and in snow peas the tender pod as well) are used as a vegetable, fresh, frozen or canned, varieties of the species typically called field peas are grown to produce dry peas like the split pea shelled from a matured pod.", "https://www.almanac.com/sites/default/files/styles/max_1300x1300/public/image_nodes/peas-and-pea-pods.jpg?itok=qWmqcepy", "Peas", "Mediterranean region", 21 },
                    { new Guid("918df8b2-4cfb-457b-8eec-23fa0fc35a2f"), 0, "Cream fresh is a dairy product, a soured cream containing 10–45% butterfat, with a pH of approximately 4.5. It is soured with a bacterial culture.", "https://images.immediate.co.uk/production/volatile/sites/30/2020/02/parmesan-00f8b31.jpg?quality=90&webp=true&resize=300,272", "Cream fresh", "France", 9 },
                    { new Guid("94bbb0e7-a4a9-4948-b6ae-e69959c71c62"), 0, "Cognac is a variety of brandy named after the commune of Cognac, France. It is produced in the surrounding wine-growing region in the departments of Charente and Charente-Maritime.Cognac production falls under French appellation d'origine contrôlée designation, with production methods and naming required to meet certain legal requirements. Among the specified grapes, Ugni blanc, known locally as Saint-Émilion, is most widely used.", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a0/Cognac_glass_-_tulip_shaped.JPG/800px-Cognac_glass_-_tulip_shaped.JPG", "Cognac", "France", 20 },
                    { new Guid("9b553652-138e-44c1-92a0-253cda2f7d79"), 0, "Squid Ink is a dark-coloured or luminous ink released into water by most species of cephalopod, usually as an escape mechanism. Modern use of cephalopod ink is generally limited to cooking, primarily in Japan and the Mediterranean, where it is used as a food colouring and flavouring, for example in pasta and sauces, and calamares en su tinta.", "https://media.npr.org/assets/img/2017/02/23/butter1_custom-340e5902a868b66b8f11aca60a5b2eed334971eb-s800-c85.webp", "Butter", "All over the world", 17 },
                    { new Guid("9ffc3a81-a39d-4c36-83c8-2a7a043a947d"), 0, "Multigrain bread is made with different types of flour and Theobroma’s multigrain loaf offers you the goodness of 8 different types of flour. This includes jowar, ragi, soya, oats and whole wheat flour.", "https://www.seasonsandsuppers.ca/wp-content/uploads/2021/09/multigrain-bread-1200-600x600.jpg", "Multigrain Loaf", "All over the world", 19 },
                    { new Guid("a38a088d-3fef-4086-8f95-b088cdc067db"), 0, "An egg is an organic vessel grown by an animal to carry a possibly fertilized egg cell (a zygote) and to incubate from it an embryo within the egg until the embryo has become an animal fetus that can survive on its own, at which point the animal hatches.", "https://i.guim.co.uk/img/media/db9a96e1251a41a215ada849407983cedadc2fbb/0_252_2574_1545/master/2574.jpg?width=620&quality=85&dpr=1&s=none", "Egg", "All over the world", 6 },
                    { new Guid("bdfce3b9-39d0-49b3-8393-48f18bf2b134"), 0, "Salmon is the common name for several commercially important species of euryhaline ray-finned fish from the family Salmonidae, which are native to tributaries of the North Atlantic (genus Salmo) and North Pacific basin. Other closely related fish in the same family include trout, char, grayling, whitefish, lenok and taimen.", "https://img.freepik.com/free-photo/raw-salmon-meat_74190-1592.jpg?w=1380&t=st=1668534014~exp=1668534614~hmac=e1cb4b7b026444b95a5c0c5f9ec2f456568e1d925029a11b6792b9481562f92f", "Salmon", "Ocean", 5 },
                    { new Guid("c78e46a6-76aa-40ed-945e-a50b7804d543"), 0, "The pistachio a member of the cashew family, is a small tree originating from Central Asia and the Middle East. The tree produces seeds that are widely consumed as food.", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f1/Pistachio_macro_whitebackground_NS.jpg/220px-Pistachio_macro_whitebackground_NS.jpg", "Pistacio", "Middle East", 18 }
                });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("b169fcbd-cde5-4a5b-8ab7-258572d98f8f"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 15, 20, 36, 47, 770, DateTimeKind.Local).AddTicks(3929));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("072818d1-6852-473a-b27b-803559c2de35"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("07a09f60-233b-4ff3-bf95-b702917ae703"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("0add8fdc-b4d9-4ea6-bc0b-89d0801d204e"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("0d4d9a46-26f5-4ec4-872a-80afae65b2b2"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("2b4a94a0-0693-4b75-9667-a57cdf3d576e"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("38ff0d4d-96df-4f76-9735-4510801e721b"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("47b234b1-5a56-4c29-a0ff-73994c4175d3"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("63cd1418-5533-4056-a82e-61d1cba11370"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("653294cb-c5fd-4c51-a470-25854918fb9d"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7e7b0452-876f-428c-b56c-61c13663e629"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("88bb61fd-478a-4431-ba19-3b45230656eb"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("918df8b2-4cfb-457b-8eec-23fa0fc35a2f"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("94bbb0e7-a4a9-4948-b6ae-e69959c71c62"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9b553652-138e-44c1-92a0-253cda2f7d79"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9ffc3a81-a39d-4c36-83c8-2a7a043a947d"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("a38a088d-3fef-4086-8f95-b088cdc067db"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bdfce3b9-39d0-49b3-8393-48f18bf2b134"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("c78e46a6-76aa-40ed-945e-a50b7804d543"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0093ae6c-d848-43bf-bc62-01c5e684f4a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4518b84b-107b-4a44-8c46-8811a2c4959e", "AQAAAAEAACcQAAAAEDVB1JqSloAvzdxHwdxcKBl02Yk6Ldl0fjzq/y/Z5PPPYAzwoV/H1ei/jtuVOKuXJg==", "8d8bd737-ec3d-4b5d-8609-8c0ea5b5d871" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc60d5f7-3884-42c6-9fb5-e1db55094536",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6ddba27-d7c0-496a-b9c0-0a52f6cc82b3", "AQAAAAEAACcQAAAAEOZl56I75LhqUleb/4ihrA/m74VxU7oxXzclztgFLyi46OPLt77wQBmUIH2ISAiYhA==", "ad5d2ac4-9a35-4777-b355-848babeff6ed" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("52a20631-47f3-45c7-a1fe-a41802908375"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("b169fcbd-cde5-4a5b-8ab7-258572d98f8f"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 10, 19, 37, 4, 511, DateTimeKind.Local).AddTicks(4982));
        }
    }
}
