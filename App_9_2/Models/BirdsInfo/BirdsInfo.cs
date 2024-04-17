using App_9_2.Models.Contracts;
using System.Collections.Generic;

namespace App_9_2.Models.BirdsInfo
{
    public static class BirdsInfo
    {
        public static List<IBird> GetTitBirds()
        {
            List<IBird> birds = new List<IBird>
            {
                new Bird()
                {
                    Name = "Голям синигер",
                    IsEndangered = false,
                    ImageUrls = {"https://bspb.org/wp-content/uploads/2021/07/P_major_2_S_Spasov.jpg", "https://atlas.bspb.org/wp-content/uploads/sites/5/2021/09/1-12_12-12-2020_%D0%A0%D0%B0%D0%B4%D0%BE%D1%81%D0%BB%D0%B0%D0%B2%D0%A0%D0%B0%D0%BD%D0%BA%D0%BE%D0%B2_Pmajor-credit.jpg" },
                    ResidesInAreas = "Среща се в цялата страна, с изключение на високопланинската безлесна зона.",
                    Description = "Дължина на тялото: 13 – 15 см\r\nНай-често срещаният синигер у нас. Главата е черна с бели бузи. Коремът е жълт, разделен от черна надлъжна ивица, която при мъжките е по-широка отколкото при женските. При младите тя почти липсва. Гърбът е жълто-зелен, а крилата имат син оттенък."
                },
                new Bird()
                {
                    Name = "Дългоопашат синигер",
                    IsEndangered = false,
                    ImageUrls = {"https://bspb.org/wp-content/uploads/2021/07/A_caudatus_S_Spasov.jpg", "https://atlas.bspb.org/wp-content/uploads/sites/5/2021/09/RosenPopov_Aegithalos-caudatus_1L5A5201_02-05-2020-credit.jpg" },
                    ResidesInAreas = "Странджа, Източните Родопи, Източна Стара планина, Средна гора, Западните погранични планини, Южен Пирин и др.",
                    Description = "Дължина на тялото: 13 – 15 см. Размах на крилата: 16 – 19 см\r\nИма топчесто тяло с дълга опашка. Често се движи на ята. Коремът и главата са светли, а гърбът – тъмен в черен и кафяв рисунък."
                },
                new Bird()
                {
                    Name = "Матоглав синигер",
                    IsEndangered = false,
                    ImageUrls = { "https://bspb.org/wp-content/uploads/2021/07/Po_montanus_B_Belchev.jpg", "https://atlas.bspb.org/wp-content/uploads/sites/5/2021/09/IMG_9321_S_Spasov-credit.jpg" },
                    ResidesInAreas = "У нас се среща в планините Рила, Пирин, Западни Родопи, Витоша, Осоговска планина, Средна гора, Централна и Западна Стара планина.",
                    Description = "Дължина на тялото: 12 – 13 см. Размах на крилата: 17 – 18 см\r\nНаподобява лъскавоглавия синигер, но черното петно на гушата е по-голямо, има светъл панел на крилото и темето е наситено черно без метален блясък. Черната шапка изтънява силно назад по врата."
                },
                new Bird()
                {
                    Name = "Жалобен синигер",
                    IsEndangered = false,
                    ImageUrls = { "https://bspb.org/wp-content/uploads/2021/07/P_lugubris_2_S_Spasov.jpg", "https://atlas.bspb.org/wp-content/uploads/sites/5/2021/08/Chlidonias-hybrida2_Ivailo-Zafirov-credit.jpg" },
                    ResidesInAreas = "Източни Родопи, Странджа, Източна Стара планина, Западна Стара планина и долината на р. Струма. Среща се и на места в Средна гора, Витоша, Западни Родопи, Лудогорието и Добруджа и др.",
                    Description = "Дължина на тялото: 13 – 14 см. Размах на крилата: 20 – 22 см\r\nОперението е подобно на това на матовоглавия синигер, но има значително по-голямо тъмно петно на гушата, така че белите бузи образуват само малък островръх триъгълник. Без светъл панел в крилото."
                },
                new Bird()
                {
                    Name = "Качулат синигер",
                    IsEndangered = false,
                    ImageUrls = {"https://bspb.org/wp-content/uploads/2021/07/Lo_cristatus_S_Spasov.jpg", "https://atlas.bspb.org/wp-content/uploads/sites/5/2021/09/crested-tit_%D0%92%D0%B5%D1%81%D0%B5%D0%BB%D0%B8%D0%BD-%D0%94%D1%80%D0%B0%D0%BD%D0%B3%D0%B0%D0%B6%D0%BE%D0%B2-credit.jpg"},
                    ResidesInAreas = "Рила, Пирин, Западни Родопи, Витоша, Централна и Западна Стара планина.",
                    Description = "Дължина на тялото: 10 – 12 см. Размах на крилата: 17 – 20 см\r\nГлавата е с ясно изразена качулка, гърлото е черно, а горната част на крилата и гърбът са кафяви. Гърдите и коремът са бели."
                },
                new Bird()
                {
                    Name = "Лъскагоглав синигер",
                    IsEndangered = false,
                    ImageUrls = { "https://bspb.org/wp-content/uploads/2021/07/P_palustris_2_S_Spasov.jpg", "https://atlas.bspb.org/wp-content/uploads/sites/5/2021/09/%D0%9B%D1%8A%D1%81%D0%BA%D0%B0%D0%B2%D0%BE%D0%B3%D0%BB%D0%B0%D0%B2-%D1%81%D0%B8%D0%BD%D0%B8%D0%B3%D0%B5%D1%80-Poecile-palustris_28-12-2020_IvanRaikov_DSCN2733-credit.jpg"},
                    ResidesInAreas = "Стара планина, Предбалкана, Рила, Пирин, Родопите, Странджа, Витоша, Лудогорието и Добруджа.",
                    Description = "Дължина на тялото: 11 – 13 см. Размах на крилата: 18 – 19 см\r\nГлавата е черна с метален блясък, гърбът е сиво-кафяв, коремът е светъл, бузите са бели. На гушата има малко черно петно. Може да се сбърка с матовоглавия синигер."
                },
                new Bird()
                {
                    Name = "Син синигер",
                    IsEndangered = false,
                    ImageUrls = {"https://bspb.org/wp-content/uploads/2021/07/Cy_caeruleus_1_S_Spasov.jpg", "https://atlas.bspb.org/wp-content/uploads/sites/5/2021/09/Parus-caeruleus_DSC_5744_cr_cr_VioletaDimitrova-credit.jpg" },
                    ResidesInAreas = "Среща се в почти цялата страна, с изключение на безлесните земеделски райони на равнините и обширните иглолистни гори на Рила и Западни Родопи.",
                    Description = "Дължина на тялото: 10 – 12 см. Размах на крилата: 17 – 20 см\r\nКоремът е жълт без черна ивица по средата, главата е светла с черна презочна ивица и синьо теме. Яката, крилата и опашката са сини, а гърбът е жълто-зелен."
                },
                new Bird()
                {
                    Name = "Торбогнезден синигер",
                    IsEndangered = false,
                    ImageUrls = {"https://bspb.org/wp-content/uploads/2021/05/R_pendulinus_S_Spasov.jpg", "https://atlas.bspb.org/wp-content/uploads/sites/5/2021/09/Remiz_pendulinus_DSC_5925_cr_cr_VioletaDimitrova-credit.jpg"},
                    ResidesInAreas = "По поречието на р. Дунав, Дунавската равнина, Черноморието, Софийското поле, южните части на долината на р. Струма и др.",
                    Description = "Дължина на тялото: 10 – 11 см. Размах на крилата: 20 см\r\nГърбът е канелено-кафяв, долната страна на тялото е светла. Мъжките са черно-кафяво напетнени в горната част на гърдите. Главата е бяла с черна „маска“ през очите, която при мъжките е по-голяма от тази при женските. Младите нямат препаска през очите."
                },
                new Bird()
                {
                    Name = "Черен (боров) синигер",
                    IsEndangered = false,
                    ImageUrls = {"https://bspb.org/wp-content/uploads/2021/07/P_ater_2_S_Spasov.jpg", "https://atlas.bspb.org/wp-content/uploads/sites/5/2021/09/%D0%91%D0%BE%D1%80%D0%BE%D0%B2-%D1%81%D0%B8%D0%BD%D0%B8%D0%B3%D0%B5%D1%80-%D0%9A%D0%BE%D0%BD%D1%81%D1%82%D0%B0%D0%BD%D1%82%D0%B8%D0%BD-%D0%99%D0%BE%D0%B2%D1%87%D0%B5%D0%B2-credit.jpg" },
                    ResidesInAreas = "Западни Родопи, Рила, Пирин, Западна и Централна Стара планина, Витоша и Осоговска планина.",
                    Description = "Дължина на тялото: 10 – 11 см. Размах на крилата: 17 – 21 см\r\nГърлото и главата са черни, с бели бузи и бяло петно на тила, което липсва при другите синигери. Горната страна на тялото и крилата са сиви, а долната страна е белезникава."
                },
            };

            return birds;
        }

        public static List<IBird> GetVultureBirds()
        {
            List<IBird> birds = new List<IBird>()
            {
                new Bird()
                {
                    Name = "Египетски лешояд",
                    IsEndangered = true,
                    ImageUrls = { "https://atlas.bspb.org/wp-content/uploads/sites/5/2021/08/IMG_7234_July15_S_Spasov-credit.jpg", "https://atlas.bspb.org/wp-content/uploads/sites/5/2021/08/Dimitar_Gradinarov_Ptici_At_14-04-03_0058-credit.jpg" },
                    ResidesInAreas = "Източните Родопи, Източна Стара планина, Провадийско–Роякското плато, Ломовете.",
                    Description = "Дължината на тялото е 60 – 70 (до 85) cm, а размахът на крилете – 150 – 170 cm. Теглото му достига 1,6 – 2,5 kg. Няма изразен полов диморфизъм. Оперението му е в светли кремави тонове, като краищата на крилете и всички махови пера са тъмни. Главата е с оголени участъци около човката в жълт цвят. Полетът е предимно планиращ."
                },
                new Bird()
                {
                    Name = "Белоглав лешояд",
                    IsEndangered = false,
                    ImageUrls = { "https://atlas.bspb.org/wp-content/uploads/sites/5/2021/08/G_fulvus_SSpasov_IMG_1412-credit.jpg", "https://atlas.bspb.org/wp-content/uploads/sites/5/2021/08/Dimitar_Gradinarov_Ptici_At_10-05-01_0048-credit.jpg" },
                    ResidesInAreas = "Автохтонната популация гнезди само в Източните Родопи, по долината на р. Арда между устието на р. Върбица и западния край на яз. Ивайловград. В последните години благодарение на програми за реинтродукция видът се среща в Източна Стара планина, Сливенско, Западна Стара планина, Кресненския пролом.",
                    Description = "Дължината на тялото е 110 cm, а размахът на крилете – 260 cm. Теглото му достига 7 kg. Главата на белоглавия лешояд е бяла, крилете са много широки, а опашката е къса. Има бяла гуша и черна човка."
                },
                new Bird()
                {
                    Name = "Черен лешояд",
                    IsEndangered = false,
                    ImageUrls = { "https://atlas.bspb.org/wp-content/uploads/sites/5/2021/08/IMG_7469_July15_S_Spasov-credit.jpg", "https://atlas.bspb.org/wp-content/uploads/sites/5/2021/08/%D0%A7%D0%B5%D1%80%D0%B5%D0%BD-%D0%BB%D0%B5%D1%88%D0%BE%D1%8F%D0%B4-%D0%A1%D0%B2%D0%B5%D1%82%D0%BE%D1%81%D0%BB%D0%B0%D0%B2-%D0%9C%D0%B8%D1%82%D0%BA%D0%BE%D0%B2-2-credit.jpg" },
                    ResidesInAreas = "Около язовир Студен кладенец и между долината на р. Арда и границата с Гърция, отделни птици при скитанията си достигат Сакар, Източна Стара планина, Рила, Пирин, Витоша и Западните погранични планини.",
                    Description = " Дължината на тялото му е 110 – 120 cm, размах на крилете 265 – 300 cm и тежи 6,3 – 12,5 kg. Няма изразен полов диморфизъм."
                }
            };

            return birds;
        }
    }
}
