using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace App_NintenShop
{
	public partial class From_NintenShop : Form
	{
        Videojuego[] Consoles_Nes,Consoles_Snes,Consoles_N64,Consoles_Gb,Consoles_Gba;
        List<Videojuego> Cart_Video_Games_List;
        #region
        Videojuego Nes_Super_mario_bros,Nes_Super_mario_bros_3,Nes_Mega_man_1,Nes_Mega_man_2,Nes_Metroid,Nes_Kirby_adventure,Nes_The_legend_of_zelda,Nes_Castlevania,Nes_Castlevania_3,Nes_Kid_ikarus,Nes_Earthbound,Nes_Bomberman,Nes_Pounch_out,Nes_Contra,Nes_Battletoads;
        Videojuego Snes_Super_mario_word,Snes_Crono_triger,Snes_Street_fighter_3,Snes_Super_mario_kart,Snes_Mega_man_x,Snes_Kirby_super_star,Snes_The_legend_of_zelda_a_link_to_the_past,Snes_Super_Castlevania_4,Snes_Super_metroid,Snes_Donkey_Kong_country,Snes_Earthbound_2,Snes_Super_Bomberman,Snes_Yoshis_island,Snes_FZero,Snes_Super_gouls_n_ghost;
        Videojuego N64_Mario_party,N64_Perfect_dark,N64_Donkey_kong_64,N64_Mario_tenis,N64_Doom_64,N64_Kirby_stars_64,N64_The_legend_of_zelda_majora_mask,N64_The_legend_of_zelda_ocarina_of_time,N64_Super_mario_64,N64_Paper_mario,N64_Pokemon_stadium,N64_Mario_kart_64,N64_Star_fox_64,N64_Bnajo_kazooie,N64_Super_smash_bros;
        Videojuego Gb_Donkey_kong,Gb_Catlevania_2_belmonts_revege,Gb_Metroid_2,Gb_Wario_land,Gb_Pokemon_amarillo,Gb_Pokemon_rojo,Gb_The_legend_of_zelda_oracle_of_seasons,Gb_Super_mario_land,Gb_The_legend_of_zelda_links_awakening,Gb_The_legend_of_zelda_oracle_of_ages,Gb_Super_mario_land_2,Gb_Mega_man_V,Gb_Mario_tennis,Gb_Kirbys_dream_land_2,Gb_Final_Fantasy_Adventure;
        Videojuego Gba_Mario_y_luigi_super_satar_saga,Gba_The_legend_of_zelda_minish_cap,Gba_Wario_land_4,Gba_Mega_Man_Zero_3,Gba_Metroid_zero_mission,Gba_Pokemon_esmeralda,Gba_Kirby_y_el_laberinto_de_los_espejos,Gba_Castlevania_Aria_of_srrow,Gba_Castlevania_circle_of_the_moon,Gba_Earthbound_3,Gba_Super_mario_advance_4,Gba_Super_mario_world,Gba_Yoshis_island_remake,Gba_Mega_Man_Zero,Gba_Metroid_fusion;
        #endregion
        int Accountan, Final_purchase, Ticket_quantity = 0;
        double Final_purchase_with_Iva = 0;
        bool Filter_Nes, Filter_Snes, Filter_Gb, Filter_N64, Filter_Gba;
        public From_NintenShop()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            string Music = @"C:\Users\Israe\Documents\Trabajos de la Universidad\personal\App_NintenShop\App_NintenShop\Resources\NintenShop.wav";
            SoundPlayer player = new SoundPlayer(Music);
            player.PlayLooping();
            Cart_Video_Games_List = new List<Videojuego>();
            Consoles_Nes = new Videojuego[15];
            Consoles_Gb = new Videojuego[15];
            Consoles_Snes = new Videojuego[15];
            Consoles_N64 = new Videojuego[15];
            Consoles_Gba = new Videojuego[15];
            Nes_Super_mario_bros = new Videojuego("Super Mario Bros", "Plataformas", "Shigeru Miyamoto", 30, "NES", 1985, 8, 1);
            Consoles_Nes[0] = Nes_Super_mario_bros;
            Nes_Super_mario_bros_3 = new Videojuego("Super Mario Bros 3", "Plataformas", "Shigeru Miyamoto", 40, "NES", 1988, 8, 1);
            Consoles_Nes[1] = Nes_Super_mario_bros_3;
            Nes_Mega_man_1 = new Videojuego("Mega Man", "Plataformas", "Akira Kitamura", 50, "NES", 1987, 8, 1);
            Consoles_Nes[2] = Nes_Mega_man_1;
            Nes_Mega_man_2 = new Videojuego("Mega Man 2", "Plataformas", "Akira Kitamura", 60, "NES", 1988, 8, 1);
            Consoles_Nes[3] = Nes_Mega_man_2;
            Nes_Metroid = new Videojuego("Metroid", "Aventura", "Hiroji Kiyotake", 40, "NES", 1986, 8, 1);
            Consoles_Nes[4] = Nes_Metroid;
            Nes_Kirby_adventure = new Videojuego("Kirby's Adventure", "Plataformas", "Masahiro Sakurai", 50, "NES", 1993, 8, 1);
            Consoles_Nes[5] = Nes_Kirby_adventure;
            Nes_The_legend_of_zelda = new Videojuego("The Legend of Zelda", "Aventura", "Shigeru Miyamoto", 50, "NES", 1986, 8, 1);
            Consoles_Nes[6] = Nes_The_legend_of_zelda;
            Nes_Castlevania = new Videojuego("Castlevania", "Plataformas", "Hitoshi Akamatsu", 30, "NES", 1986, 8, 1);
            Consoles_Nes[7] = Nes_Castlevania;
            Nes_Castlevania_3 = new Videojuego("Castlevania III: Dracula's Curse", "Plataformas", "Jun Funahashi", 40, "NES", 1989, 8, 1);
            Consoles_Nes[8] = Nes_Castlevania_3;
            Nes_Kid_ikarus = new Videojuego("Kid Icarus", "Aventura", "Toru Osawa", 50, "NES", 1986, 8, 1);
            Consoles_Nes[9] = Nes_Kid_ikarus;
            Nes_Earthbound = new Videojuego("EarthBound Beginnings", "RPG", "Shigesato Itoi", 100, "NES", 1989, 8, 1);
            Consoles_Nes[10] = Nes_Earthbound;
            Nes_Bomberman = new Videojuego("Bomberman", "Puzzle", "Shinichi Nakamoto", 40, "NES", 1985, 8, 1);
            Consoles_Nes[11] = Nes_Bomberman;
            Nes_Pounch_out = new Videojuego("Punch-Out!!", "Deportes", "Genyo Takeda", 30, "NES", 1987, 8, 1);
            Consoles_Nes[12] = Nes_Pounch_out;
            Nes_Contra = new Videojuego("Contra", "Plataformas", "Kazuhisa Hashimoto", 40, "NES", 1987, 8, 1);
            Consoles_Nes[13] = Nes_Contra;
            Nes_Battletoads = new Videojuego("Battletoads", "Plataformas", "Rare Ltd.", 60, "NES", 1991, 8, 1);
            Consoles_Nes[14] = Nes_Battletoads;
            Snes_Super_mario_word = new Videojuego("Super Mario World", "Plataformas", "Shigeru Miyamoto", 50, "SNES", 1990, 16, 1);
            Consoles_Snes[0] = Snes_Super_mario_word;
            Snes_Crono_triger = new Videojuego("Chrono Trigger", "RPG", "Yuji H, Akira Toriyama y Hironobu S", 200, "SNES", 1995, 16, 1);
            Consoles_Snes[1] = Snes_Crono_triger;
            Snes_Street_fighter_3 = new Videojuego("Street Fighter II: Turbo", "Lucha", "Akira Nishitani, Akira Yasuda", 30, "SNES", 1993, 16, 1);
            Consoles_Snes[2] = Snes_Street_fighter_3;
            Snes_Super_mario_kart = new Videojuego("Super Mario Kart", "Carreras", "Shigeru Miyamoto", 80, "SNES", 1992, 16, 1);
            Consoles_Snes[3] = Snes_Super_mario_kart;
            Snes_Mega_man_x = new Videojuego("Mega Man X", "Plataformas", "Keiji Inafune", 120, "SNES", 1993, 16, 1);
            Consoles_Snes[4] = Snes_Mega_man_x;
            Snes_Kirby_super_star = new Videojuego("Kirby Super Star", "Plataformas", "Masahiro Sakurai", 70, "SNES", 1996, 16, 1);
            Consoles_Snes[5] = Snes_Kirby_super_star;
            Snes_The_legend_of_zelda_a_link_to_the_past = new Videojuego("The Legend of Zelda: A Link to the Past", "Aventura", "Shigeru Miyamoto", 150, "SNES", 1992, 16, 1);
            Consoles_Snes[6] = Snes_The_legend_of_zelda_a_link_to_the_past;
            Snes_Super_Castlevania_4 = new Videojuego("Super Castlevania IV", "Plataformas", "Tomoya T, Masanori A. y Masahiro U", 90, "SNES", 1991, 16, 1);
            Consoles_Snes[7] = Snes_Super_Castlevania_4;
            Snes_Super_metroid = new Videojuego("Super Metroid", "Aventura/Acción", "Nintendo R&D1", 70, "SNES", 1994, 16, 1);
            Consoles_Snes[8] = Snes_Super_metroid;
            Snes_Donkey_Kong_country = new Videojuego("Donkey Kong Country", "Plataformas", "Rare", 50, "SNES", 1994, 16, 1);
            Consoles_Snes[9] = Snes_Donkey_Kong_country;
            Snes_Earthbound_2 = new Videojuego("Mother 2 (EarthBound)", "RPG", "Ape Inc., HAL Laboratory", 150, "SNES", 1995, 16, 1);
            Consoles_Snes[10] = Snes_Earthbound_2;
            Snes_Super_Bomberman = new Videojuego("Super Bomberman", "Puzzle", "Hudson Soft", 30, "SNES", 1993, 16, 1);
            Consoles_Snes[11] = Snes_Super_Bomberman;
            Snes_Yoshis_island = new Videojuego("Yoshi's Island", "Plataformas", "Nintendo EAD", 60, "SNES", 1995, 16, 1);
            Consoles_Snes[12] = Snes_Yoshis_island;
            Snes_FZero = new Videojuego("F-Zero", "Carreras", "Nintendo EAD", 40, "SNES", 1990, 16, 1);
            Consoles_Snes[13] = Snes_FZero;
            Snes_Super_gouls_n_ghost = new Videojuego("Super Ghouls 'n Ghosts", "Plataformas", "Capcom", 60, "SNES", 1991, 16, 1);
            Consoles_Snes[14] = Snes_Super_gouls_n_ghost;
            N64_Mario_party = new Videojuego("Mario Party", "Party", "Hudson Soft", 30, "N64", 1998, 64, 1);
            Consoles_N64[0] = N64_Mario_party;
            N64_Perfect_dark = new Videojuego("Perfect Dark", "First-person shooter", "Rare", 30, "N64", 2000, 64, 1);
            Consoles_N64[1] = N64_Perfect_dark;
            N64_Donkey_kong_64 = new Videojuego("Donkey Kong 64", "Plataformas", "Rare", 30, "N64", 1999, 64, 1);
            Consoles_N64[2] = N64_Donkey_kong_64;
            N64_Mario_tenis = new Videojuego("Mario Tennis 64", "Deportes", "Camelot Software Planning", 30, "N64", 2000, 64, 1);
            Consoles_N64[3] = N64_Mario_tenis;
            N64_Doom_64 = new Videojuego("Doom 64", "First-person shooter", "Midway Games", 30, "N64", 1997, 64, 1);
            Consoles_N64[4] = N64_Doom_64;
            N64_Kirby_stars_64 = new Videojuego("Kirby 64: The Crystal Shards", "Plataformas", "HAL Laboratory", 30, "N64", 2000, 64, 1);
            Consoles_N64[5] = N64_Kirby_stars_64;
            N64_The_legend_of_zelda_majora_mask = new Videojuego("The Legend of Zelda: Majora's Mask", "Aventura", "Nintendo EAD", 30, "N64", 2000, 64, 1);
            Consoles_N64[6] = N64_The_legend_of_zelda_majora_mask;
            N64_The_legend_of_zelda_ocarina_of_time = new Videojuego("The Legend of Zelda: Ocarina of Time", "Aventura", "Nintendo EAD", 30, "N64", 1998, 64, 1);
            Consoles_N64[7] = N64_The_legend_of_zelda_ocarina_of_time;
            N64_Super_mario_64 = new Videojuego("Super Mario 64", "Plataformas", "Nintendo EAD", 30, "N64", 1996, 64, 1);
            Consoles_N64[8] = N64_Super_mario_64;
            N64_Paper_mario = new Videojuego("Paper Mario", "RPG", "Intelligent Systems", 30, "N64", 2001, 64, 1);
            Consoles_N64[9] = N64_Paper_mario;
            N64_Pokemon_stadium = new Videojuego("Pokémon Stadium", "Estrategia", "Nintendo EAD", 30, "N64", 1999, 64, 1);
            Consoles_N64[10] = N64_Pokemon_stadium;
            N64_Mario_kart_64 = new Videojuego("Mario Kart 64", "Carreras", "Nintendo EAD", 30, "N64", 1996, 64, 1);
            Consoles_N64[11] = N64_Mario_kart_64;
            N64_Star_fox_64 = new Videojuego("Star Fox 64", "Simulación de combate espacial", "Nintendo EAD", 30, "N64", 1997, 64, 1);
            Consoles_N64[12] = N64_Star_fox_64;
            N64_Bnajo_kazooie = new Videojuego("Banjo-Kazooie", "Plataformas", "Gregg Mayles", 40, "Nintendo 64", 1998, 64, 1);
            Consoles_N64[13] = N64_Bnajo_kazooie;
            N64_Super_smash_bros = new Videojuego("Super Smash Bros", "Lucha", "Masahiro Sakurai", 45, "Nintendo 64", 1999, 64, 1);
            Consoles_N64[14] = N64_Super_smash_bros;
            Gb_Donkey_kong = new Videojuego("Donkey Kong", "Plataformas", "Nintendo R&D1", 20, "Game Boy", 1994, 8, 1);
            Consoles_Gb[0] = Gb_Donkey_kong;
            Gb_Catlevania_2_belmonts_revege = new Videojuego("Castlevania II: Belmont's Revenge", "Aventura/Plataformas", "Konami", 12, "Game Boy", 1991, 8, 1);
            Consoles_Gb[1] = Gb_Catlevania_2_belmonts_revege;
            Gb_Metroid_2 = new Videojuego("Metroid II: Return of Samus", "Aventura/Plataformas", "Nintendo R&D1", 15, "Game Boy", 1991, 8, 1);
            Consoles_Gb[2] = Gb_Metroid_2;
            Gb_Wario_land = new Videojuego("Wario Land: Super Mario Land 3", "Plataformas", "Nintendo R&D1", 25, "Game Boy", 1994, 8, 1);
            Consoles_Gb[3] = Gb_Wario_land;
            Gb_Pokemon_amarillo = new Videojuego("Pokémon Amarillo", "RPG", "Game Freak", 35, "Game Boy", 1999, 8, 1);
            Consoles_Gb[4] = Gb_Pokemon_amarillo;
            Gb_Pokemon_rojo = new Videojuego("Pokémon Rojo", "RPG", "Game Freak", 30, "Game Boy", 1998, 8, 1);
            Consoles_Gb[5] = Gb_Pokemon_rojo;
            Gb_The_legend_of_zelda_oracle_of_seasons = new Videojuego("The Legend of Zelda: Oracle of Seasons", "Aventura/RPG", "Capcom", 30, "Game Boy Color", 2001, 8, 1);
            Consoles_Gb[6] = Gb_The_legend_of_zelda_oracle_of_seasons;
            Gb_Super_mario_land = new Videojuego("Super Mario Land", "Plataformas", "Nintendo R&D1", 15, "Game Boy", 1989, 8, 1);
            Consoles_Gb[7] = Gb_Super_mario_land;
            Gb_The_legend_of_zelda_links_awakening = new Videojuego("The Legend of Zelda: Link's Awakening", "Aventura/RPG", "Nintendo EAD", 25, "Game Boy", 1993, 8, 1);
            Consoles_Gb[8] = Gb_The_legend_of_zelda_links_awakening;
            Gb_The_legend_of_zelda_oracle_of_ages = new Videojuego("The Legend of Zelda: Oracle of Ages", "Aventura/RPG", "Capcom", 30, "Game Boy Color", 2001, 8, 1);
            Consoles_Gb[9] = Gb_The_legend_of_zelda_oracle_of_ages;
            Gb_Super_mario_land_2 = new Videojuego("Super mario land 2", "Plataformas", "Nintendo R&D1", 20, "Game Boy Color", 1998, 8, 1);
            Consoles_Gb[10] = Gb_Super_mario_land_2;
            Gb_Mega_man_V = new Videojuego("Mega Man V", "Plataformas/Acción", "Capcom", 20, "Game Boy", 1994, 8, 1);
            Consoles_Gb[11] = Gb_Mega_man_V;
            Gb_Mario_tennis = new Videojuego("Mario Tennis", "Deportes", "Nintendo R&D1", 30, "Game Boy", 1995, 8, 1);
            Consoles_Gb[12] = Gb_Mario_tennis;
            Gb_Kirbys_dream_land_2 = new Videojuego("Kirby's Dream Land 2", "Plataformas", "Shinichi Shimomura", 30, "Game Boy", 1995, 8, 1);
            Consoles_Gb[13] = Gb_Kirbys_dream_land_2;
            Gb_Final_Fantasy_Adventure = new Videojuego("Final Fantasy Adventure", "Rol", "Koichi Ishii", 30, "Game Boy", 1991, 8, 1);
            Consoles_Gb[14] = Gb_Final_Fantasy_Adventure;
            Gba_Mario_y_luigi_super_satar_saga = new Videojuego("Mario & Luigi: Superstar Saga", "RPG", "AlphaDream", 40, "GBA", 2003, 32, 1);
            Consoles_Gba[0] = Gba_Mario_y_luigi_super_satar_saga;
            Gba_The_legend_of_zelda_minish_cap = new Videojuego("The Legend of Zelda: The Minish Cap", "Acción-aventura", "Capcom", 40, "GBA", 2004, 32, 1);
            Consoles_Gba[1] = Gba_The_legend_of_zelda_minish_cap;
            Gba_Wario_land_4 = new Videojuego("Wario Land 4", "Plataformas", "Nintendo R&D1", 30, "GBA", 2001, 32, 1);
            Consoles_Gba[2] = Gba_Wario_land_4;
            Gba_Mega_Man_Zero_3 = new Videojuego("Mega Man Zero 3", "Plataformas", "Capcom", 45, "GBA", 2004, 32, 1);
            Consoles_Gba[3] = Gba_Mega_Man_Zero_3;
            Gba_Metroid_zero_mission = new Videojuego("Metroid Zero Mission", "Acción-aventura", "Nintendo R&D1", 30, "GBA", 2004, 32, 1);
            Consoles_Gba[4] = Gba_Metroid_zero_mission;
            Gba_Pokemon_esmeralda = new Videojuego("Pokemon Esmeralda", "RPG", "Game Freak", 40, "GBA", 2005, 32, 1);
            Consoles_Gba[5] = Gba_Pokemon_esmeralda;
            Gba_Kirby_y_el_laberinto_de_los_espejos = new Videojuego("Kirby y el Laberinto de los Espejos", "Plataformas", "HAL Laboratory", 30, "GBA", 2004, 32, 1);
            Consoles_Gba[6] = Gba_Kirby_y_el_laberinto_de_los_espejos;
            Gba_Castlevania_Aria_of_srrow = new Videojuego("Castlevania: Aria of Sorrow", "Acción-aventura", "Konami", 40, "GBA", 2003, 32, 1);
            Consoles_Gba[7] = Gba_Castlevania_Aria_of_srrow;
            Gba_Castlevania_circle_of_the_moon = new Videojuego("Castlevania: Circle of the Moon", "Acción-aventura", "Konami", 30, "GBA", 2001, 32, 1);
            Consoles_Gba[8] = Gba_Castlevania_circle_of_the_moon;
            Gba_Earthbound_3 = new Videojuego("Mother 3", "RPG", "Brownie Brown", 40, "GBA", 2006, 32, 1);
            Consoles_Gba[9] = Gba_Earthbound_3;
            Gba_Super_mario_advance_4 = new Videojuego("Super Mario Advance 4: Super Mario Bros 3", "Plataformas", "Nintendo R&D2", 30, "GBA", 2003, 32, 1);
            Consoles_Gba[10] = Gba_Super_mario_advance_4;
            Gba_Super_mario_world = new Videojuego("Super Mario World: Super Mario Advance 2", "Plataformas", "Nintendo EAD", 30, "GBA", 2002, 32, 1);
            Consoles_Gba[11] = Gba_Super_mario_world;
            Gba_Yoshis_island_remake = new Videojuego("Yoshi's Island: Super Mario Advance 3", "Plataformas", "Nintendo", 25, "GBA", 2002, 32, 1);
            Consoles_Gba[12] = Gba_Yoshis_island_remake;
            Gba_Mega_Man_Zero = new Videojuego("Mega Man Zero", "Plataformas", "Capcom", 40, "GBA", 2003, 32, 1);
            Consoles_Gba[13] = Gba_Mega_Man_Zero;
            Gba_Metroid_fusion = new Videojuego("Metroid Fusion", "Acción, aventura", "Nintendo R&D1", 30, "GBA", 2002, 32, 1);
            Consoles_Gba[14] = Gba_Metroid_fusion;
            Filter_Nes = true;
            Filter_Snes = false;
            Filter_Gb = false;
            Filter_N64 = false;
            Filter_Gba = false;
        }
        public void Btm_filter_nes_Click(object sender, EventArgs e)
		{
            Filter_Nes = true;
            Filter_Snes = false;
            Filter_Gb = false;
            Filter_N64 = false;
            Filter_Gba = false;
            Filter_Games(Filter_Nes, Consoles_Nes);
        }

        public void Btm_filter_gb_Click(object sender, EventArgs e)
		{
            Filter_Nes = false;
            Filter_Snes = false;
            Filter_Gb = true;
            Filter_N64 = false;
            Filter_Gba = false;
            Filter_Games(Filter_Gb, Consoles_Gb);
        }

        public void Btm_filter_snes_Click(object sender, EventArgs e)
		{
            Filter_Nes = false;
            Filter_Snes = true;
            Filter_Gb = false;
            Filter_N64 = false;
            Filter_Gba = false;
            Filter_Games(Filter_Snes, Consoles_Snes);
        }

        public void Btm_filter_n64_Click(object sender, EventArgs e)
		{
            Filter_Nes = false;
            Filter_Snes = false;
            Filter_Gb = false;
            Filter_N64 = true;
            Filter_Gba = false;
            Filter_Games(Filter_N64, Consoles_N64);
        }

        public void Btm_filter_gba_Click(object sender, EventArgs e)
		{
            Filter_Nes = false;
            Filter_Snes = false;
            Filter_Gb = false;
            Filter_N64 = false;
            Filter_Gba = true;
            Filter_Games(Filter_Gba, Consoles_Gba);
        }

        private void List_juegos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Selected_Index = List_juegos.SelectedIndex;
            if (Selected_Index != -1)
            {
                Videojuego Selected_Game = null;
                if (Filter_Nes == true)
                {
                    Selected_Game = Consoles_Nes[Selected_Index];
                    Information_Game(Consoles_Nes, Selected_Index);
                }
                else if (Filter_Gb == true)
                {
                    Selected_Game = Consoles_Gb[Selected_Index];
                    Information_Game(Consoles_Gb, Selected_Index);
                }
                else if (Filter_Snes == true)
                {
                    Selected_Game = Consoles_Snes[Selected_Index];
                    Information_Game(Consoles_Snes, Selected_Index);
                }
                else if (Filter_N64 == true)
                {
                    Selected_Game = Consoles_N64[Selected_Index];
                    Information_Game(Consoles_N64, Selected_Index);
                }
                else
                {
                    Selected_Game = Consoles_Gba[Selected_Index];
                    Information_Game(Consoles_Gba, Selected_Index);
                }
                if (Selected_Game != null)
                {
                    Change_Game_Image(Selected_Game.TITLE);
                }
            }
        }

        private void Btn_comprar_Click(object sender, EventArgs e)
        {
            int Selected_Game_Buy = List_juegos.SelectedIndex;
            if (Filter_Nes == true)
            {
                Process_Purchase(Consoles_Nes, Selected_Game_Buy);
            }
            else if(Filter_Gb == true)
            {
                Process_Purchase(Consoles_Gb, Selected_Game_Buy);
            }
            else if (Filter_Snes == true)
            {
                Process_Purchase(Consoles_Snes, Selected_Game_Buy);
            }
            else if (Filter_N64 == true)
            {
                Process_Purchase(Consoles_N64, Selected_Game_Buy);
            }
            else
            {
                Process_Purchase(Consoles_Gba, Selected_Game_Buy);
            }
        }

        private void InicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Carrito.Visible = false;
            Panel_Ayuda.Visible = false;
        }

        private void CarritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Carrito.Visible = true;
            Panel_Ayuda.Visible = false;
        }

        private void AyudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Panel_Carrito.Visible = true;
            Panel_Ayuda.Visible = true;
        }

        private void Btn_carrito_Click(object sender, EventArgs e)
        {
            Panel_Carrito.Visible = true;
            Panel_Ayuda.Visible = false;
        }

        private void Btn_eliminar_carrito_Click(object sender, EventArgs e)
        {
            if (List_carrito.SelectedItems.Count == 0)
            {
                return;
            }
            int Selected_Index = List_carrito.SelectedIndices[0];
            Videojuego Deleted_Video_game = Cart_Video_Games_List[Selected_Index];
            Final_purchase -= (Deleted_Video_game.PRICE);
            Final_purchase_with_Iva -= Math.Round((Deleted_Video_game.PRICE * .16), 2);
            List_carrito.Items.RemoveAt(Selected_Index);
            Cart_Video_Games_List.RemoveAt(Selected_Index);
            Accountan -= 1;
            llbl_compra_iva_carrito.Text = $"${Math.Round((Final_purchase * .16), 2).ToString()}" + ".";
            lbl_compra_total_carrito.Text = $"${Final_purchase.ToString()}" + ".";
            lbl_contador_carrito.Text = Accountan.ToString();
        }

        private void Btn_imprimir_carrito_Click(object sender, EventArgs e)
        {
            if (Cart_Video_Games_List.Count > 0)
            {
                Ticket_quantity++;
                string Date_Time_Ticket = DateTime.Now.ToString();
                string Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string Ticket = Path.Combine(Desktop, $"NintenShop {Ticket_quantity}.txt");
                try
                {
                    using (StreamWriter File = new StreamWriter(Ticket))
                    {
                        File.WriteLine($"NintenShop Inc.                  {Date_Time_Ticket}\n");
                        foreach (Consola Console in Cart_Video_Games_List)
                        {
                            File.WriteLine(Console.Ticket());
                        }
                        File.WriteLine($"Iva: ${Final_purchase_with_Iva}.");
                        File.WriteLine($"Compra Total: ${Final_purchase}.");
                        File.WriteLine("\nGracias por comprar en NintenShop Inc.");
                        File.Close();
                    }
                    Console.Beep();
                    MessageBox.Show("Ticke impreso exitosamente...");
                    List_carrito.Items.Clear();
                    Cart_Video_Games_List.Clear();
                    llbl_compra_iva_carrito.Text = "--";
                    lbl_compra_total_carrito.Text = "--";
                    lbl_contador_carrito.Text = "0";
                    Accountan = 0;
                    Final_purchase_with_Iva = 0;
                    Final_purchase = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al imprimir el ticket..." + ex.Message);
                }
            }
        }

        private void Btn_añadir_carrito_Click(object sender, EventArgs e)
        {
            int Selected_Game_Buy = List_juegos.SelectedIndex;
            Videojuego Selected_Game = null;
            if (Filter_Nes == true)
            {
                Selected_Game = Consoles_Nes[Selected_Game_Buy];
                Add_Cart_Item(Selected_Game);
            }
            else if (Filter_Gb == true)
            {
                Selected_Game = Consoles_Gb[Selected_Game_Buy];
                Add_Cart_Item(Selected_Game);
            }
            else if (Filter_Snes == true)
            {
                Selected_Game = Consoles_Snes[Selected_Game_Buy];
                Add_Cart_Item(Selected_Game);
            }
            else if (Filter_N64 == true)
            {
                Selected_Game = Consoles_N64[Selected_Game_Buy];
                Add_Cart_Item(Selected_Game);
            }
            else
            {
                Selected_Game = Consoles_Gba[Selected_Game_Buy];
                Add_Cart_Item(Selected_Game);
            }
        }

        private void Filter_Games(bool Filter,Videojuego[] Video_Games)
        {
            if (Filter != false)
            {
                List_juegos.Items.Clear();
                foreach (Consola Consoles in Video_Games)
                {
                    if (Consoles is Videojuego Video_Game)
                    {
                        List_juegos.Items.Add(Video_Game.TITLE);
                    }
                }
                List_juegos.SelectedIndex = 0;
                return;
            }
        }

        private void Process_Purchase(Videojuego[] Video_Games, int Selected_Index)
        {
            if (Selected_Index != -1)
            {
                Videojuego Selected_Game = Video_Games[Selected_Index];
                double Buy = Selected_Game.PRICE;
                double Iva = Math.Round((Buy / 1.16) * .16, 2);
                Buy = Math.Round(Buy - Iva, 2);
                double Final_Purchase = Buy + Iva;
                Console.Beep();
                MessageBox.Show(
                    $"NintenShop            {DateTime.Now}\n\n"
                    + "Titulo: " + $"{Selected_Game.TITLE}" + "\n"
                    + "Genero: " + $"{Selected_Game.GENERE}" + "\n"
                    + "Año: " + $"{Selected_Game.YEAR}" + "\n"
                    + "Precio: " + $"{Selected_Game.PRICE}" + "\n\n"
                    + "Iva: " + $"${Iva}" + "\n"
                    + "Total:" + $" ${Buy}\n\n"
                    + "Sub Total Final:" + $" ${Final_Purchase}\n"
                    + "Gracias por su compra.");
            }
        }

        private void Information_Game(Videojuego[] Video_Games, int Selected_Image)
        {
            Videojuego Selected_Game = Video_Games[Selected_Image];
            lbl_titulo.Text = "Título: " + Selected_Game.TITLE + ".";
            lbl_genero.Text = "Género: " + Selected_Game.GENERE + ".";
            lbl_creadores.Text = "Creador(es): " + Selected_Game.CREATORS + ".";
            lbl_año.Text = "Año: " + Selected_Game.YEAR.ToString() + ".";
            lbl_consola.Text = "Consola: " + Selected_Game.CONSOLE + ".";
            lbl_precio.Text = "$" + Selected_Game.PRICE.ToString() + ".";
            lbl_bits.Text = "Bits: " + Selected_Game.BITS.ToString() + ".";
        }

        private void Add_Cart_Item(Videojuego Game)
        {
            if (!Cart_Video_Games_List.Contains(Game))
            {
                Cart_Video_Games_List.Add(Game);
                Accountan++;
                lbl_contador_carrito.Text = Accountan.ToString();
                Final_purchase += Game.PRICE;
                Final_purchase_with_Iva = Math.Round((Final_purchase * 0.16), 2);
                Console.Beep();
                Videojuego Add_Console = Cart_Video_Games_List.Last();
                List_carrito.Items.Add(Add_Console.ToString());
                llbl_compra_iva_carrito.Text = $"${Final_purchase_with_Iva.ToString()}" + ".";
                lbl_compra_total_carrito.Text = $"${Final_purchase.ToString()}" + ".";
            }
        }

        private void Change_Game_Image(string Video_Game_Name)
        {
            switch (Video_Game_Name)
            {
                case "Super Mario Bros":
                    Pic_Caratulas.Image = Properties.Resources.Ness_Super_mario_bros;
                    break;
                case "Super Mario Bros 3":
                    Pic_Caratulas.Image = Properties.Resources.Ness_Super_mario_bros_3;
                    break;
                case "Mega Man":
                    Pic_Caratulas.Image = Properties.Resources.Ness_Mega_man_1;
                    break;
                case "Mega Man 2":
                    Pic_Caratulas.Image = Properties.Resources.Ness_Mega_man_2;
                    break;
                case "Metroid":
                    Pic_Caratulas.Image = Properties.Resources.Ness_Metroid;
                    break;
                case "Kirby's Adventure":
                    Pic_Caratulas.Image = Properties.Resources.Ness_Kirby_adventure;
                    break;
                case "The Legend of Zelda":
                    Pic_Caratulas.Image = Properties.Resources.Ness_The_legen_of_zelda;
                    break;
                case "Castlevania":
                    Pic_Caratulas.Image = Properties.Resources.Ness_Castlevania;
                    break;
                case "Castlevania III: Dracula's Curse":
                    Pic_Caratulas.Image = Properties.Resources.Ness_Castlevania_3;
                    break;
                case "Kid Icarus":
                    Pic_Caratulas.Image = Properties.Resources.Ness_kid_ikarus;
                    break;
                case "EarthBound Beginnings":
                    Pic_Caratulas.Image = Properties.Resources.Ness_Earthbound;
                    break;
                case "Bomberman":
                    Pic_Caratulas.Image = Properties.Resources.Ness_Bomberman;
                    break;
                case "Punch-Out!!":
                    Pic_Caratulas.Image = Properties.Resources.Ness_Ponch_out;
                    break;
                case "Contra":
                    Pic_Caratulas.Image = Properties.Resources.Ness_Contra;
                    break;
                case "Battletoads":
                    Pic_Caratulas.Image = Properties.Resources.Ness_Battletoads;
                    break;
                case "Donkey Kong":
                    Pic_Caratulas.Image = Properties.Resources.Gb_Donkey_kong;
                    break;
                case "Castlevania II: Belmont's Revenge":
                    Pic_Caratulas.Image = Properties.Resources.Gb_Castlevania_2;
                    break;
                case "Metroid II: Return of Samus":
                    Pic_Caratulas.Image = Properties.Resources.Gb_Metroid_2;
                    break;
                case "Wario Land: Super Mario Land 3":
                    Pic_Caratulas.Image = Properties.Resources.Gb_Wario_land_1;
                    break;
                case "Pokémon Amarillo":
                    Pic_Caratulas.Image = Properties.Resources.Gb_Pokemon_amarillo;
                    break;
                case "Pokémon Rojo":
                    Pic_Caratulas.Image = Properties.Resources.Gb_Pokemon_rojo;
                    break;
                case "The Legend of Zelda: Oracle of Seasons":
                    Pic_Caratulas.Image = Properties.Resources.Gb_The_legend_of_zelda_seasons;
                    break;
                case "The Legend of Zelda: Oracle of Ages":
                    Pic_Caratulas.Image = Properties.Resources.Gb_The_legend_of_zelda_ages;
                    break;
                case "The Legend of Zelda: Link's Awakening":
                    Pic_Caratulas.Image = Properties.Resources.Gb_The_legend_of_zelda_links_awakening;
                    break;
                case "Super Mario Land":
                    Pic_Caratulas.Image = Properties.Resources.Gb_Super_mario_land;
                    break;
                case "Super mario land 2":
                    Pic_Caratulas.Image = Properties.Resources.Gb_Super_mario_land_2;
                    break;
                case "Mega Man V":
                    Pic_Caratulas.Image = Properties.Resources.Gb_Mega_man_V;
                    break;
                case "Mario Tennis":
                    Pic_Caratulas.Image = Properties.Resources.Gb_Mario_tennis;
                    break;
                case "Kirby's Dream Land 2":
                    Pic_Caratulas.Image = Properties.Resources.Gb_Kirby_dream_land_2;
                    break;
                case "Final Fantasy Adventure":
                    Pic_Caratulas.Image = Properties.Resources.Gb_Final_fantasy_adventure;
                    break;
                case "Super Mario World":
                    Pic_Caratulas.Image = Properties.Resources.Snes_Super_mario_world;
                    break;
                case "Chrono Trigger":
                    Pic_Caratulas.Image = Properties.Resources.Snes_Crono_triger;
                    break;
                case "Street Fighter II: Turbo":
                    Pic_Caratulas.Image = Properties.Resources.Snes_Street_fighter_2;
                    break;
                case "Super Mario Kart":
                    Pic_Caratulas.Image = Properties.Resources.Snes_Super_mario_kart;
                    break;
                case "Mega Man X":
                    Pic_Caratulas.Image = Properties.Resources.Snes_Mega_man_X;
                    break;
                case "Kirby Super Star":
                    Pic_Caratulas.Image = Properties.Resources.Snes_Kirby_super_star;
                    break;
                case "The Legend of Zelda: A Link to the Past":
                    Pic_Caratulas.Image = Properties.Resources.Snes_The_legen_of_zelda_link_to_the_past;
                    break;
                case "Super Castlevania IV":
                    Pic_Caratulas.Image = Properties.Resources.Snes_Super_castlevania_4;
                    break;
                case "Super Metroid":
                    Pic_Caratulas.Image = Properties.Resources.Snes_Super_metroid;
                    break;
                case "Donkey Kong Country":
                    Pic_Caratulas.Image = Properties.Resources.Snes_Donkey_kong_country;
                    break;
                case "Mother 2 (EarthBound)":
                    Pic_Caratulas.Image = Properties.Resources.Sness_Earthbound_2;
                    break;
                case "Super Bomberman":
                    Pic_Caratulas.Image = Properties.Resources.Snes_Super_bomberman;
                    break;
                case "Yoshi's Island":
                    Pic_Caratulas.Image = Properties.Resources.Snes_Yoshi_island;
                    break;
                case "F-Zero":
                    Pic_Caratulas.Image = Properties.Resources.Sness_Fzero;
                    break;
                case "Super Ghouls 'n Ghosts":
                    Pic_Caratulas.Image = Properties.Resources.Sness_Super_ghoulsn_ghostsjpg;
                    break;
                case "Mario Party":
                    Pic_Caratulas.Image = Properties.Resources.N64_Mario_party;
                    break;
                case "Perfect Dark":
                    Pic_Caratulas.Image = Properties.Resources.N64_Perfect_dark;
                    break;
                case "Donkey Kong 64":
                    Pic_Caratulas.Image = Properties.Resources.N64_Donkey_kong_64;
                    break;
                case "Mario Tennis 64":
                    Pic_Caratulas.Image = Properties.Resources.N64_Mario_tennis;
                    break;
                case "Doom 64":
                    Pic_Caratulas.Image = Properties.Resources.N64_Doom_64;
                    break;
                case "Kirby 64: The Crystal Shards":
                    Pic_Caratulas.Image = Properties.Resources.N64_Kirby_stars_64;
                    break;
                case "The Legend of Zelda: Majora's Mask":
                    Pic_Caratulas.Image = Properties.Resources.N64_The_legend_of_zelda_majora_mask;
                    break;
                case "The Legend of Zelda: Ocarina of Time":
                    Pic_Caratulas.Image = Properties.Resources.N64_The_legend_of_zelda_ocarina_of_time;
                    break;
                case "Super Mario 64":
                    Pic_Caratulas.Image = Properties.Resources.N64_Super_mario_64;
                    break;
                case "Paper Mario":
                    Pic_Caratulas.Image = Properties.Resources.N64_Paper_mario;
                    break;
                case "Pokémon Stadium":
                    Pic_Caratulas.Image = Properties.Resources.N64_Pokemon_stadium;
                    break;
                case "Mario Kart 64":
                    Pic_Caratulas.Image = Properties.Resources.N64_Mario_kart_64;
                    break;
                case "Star Fox 64":
                    Pic_Caratulas.Image = Properties.Resources.N64_Star_fox_64;
                    break;
                case "Banjo-Kazooie":
                    Pic_Caratulas.Image = Properties.Resources.N64_Banjo_kazooie;
                    break;
                case "Super Smash Bros":
                    Pic_Caratulas.Image = Properties.Resources.N64_Super_smash_bros;
                    break;
                case "Mario & Luigi: Superstar Saga":
                    Pic_Caratulas.Image = Properties.Resources.Gba_Mario_y_luigi_super_star_saga;
                    break;
                case "The Legend of Zelda: The Minish Cap":
                    Pic_Caratulas.Image = Properties.Resources.Gba_The_legend_of_zelda_minish_cap;
                    break;
                case "Wario Land 4":
                    Pic_Caratulas.Image = Properties.Resources.Gba_Wario_land_4;
                    break;
                case "Mega Man Zero 3":
                    Pic_Caratulas.Image = Properties.Resources.Gba_Mega_Man_Zero_3;
                    break;
                case "Metroid Zero Mission":
                    Pic_Caratulas.Image = Properties.Resources.Gba_Metroid_zero_mission;
                    break;
                case "Pokemon Esmeralda":
                    Pic_Caratulas.Image = Properties.Resources.Gba_Pokemon_esmeralda;
                    break;
                case "Kirby y el Laberinto de los Espejos":
                    Pic_Caratulas.Image = Properties.Resources.Gba_Kirby_amasing_mirrow;
                    break;
                case "Castlevania: Aria of Sorrow":
                    Pic_Caratulas.Image = Properties.Resources.Gba_Castlevania_arrial_of_sorrow;
                    break;
                case "Castlevania: Circle of the Moon":
                    Pic_Caratulas.Image = Properties.Resources.Gba_Castlevania_cirvcle_of_moon;
                    break;
                case "Mother 3":
                    Pic_Caratulas.Image = Properties.Resources.Gba_Mother_3;
                    break;
                case "Super Mario Advance 4: Super Mario Bros 3":
                    Pic_Caratulas.Image = Properties.Resources.Gba_Super_mario_advance_4;
                    break;
                case "Super Mario World: Super Mario Advance 2":
                    Pic_Caratulas.Image = Properties.Resources.Gba_Super_mario_world;
                    break;
                case "Yoshi's Island: Super Mario Advance 3":
                    Pic_Caratulas.Image = Properties.Resources.Gba_Yoshi_island;
                    break;
                case "Mega Man Zero":
                    Pic_Caratulas.Image = Properties.Resources.Gba_Mega_Man_Zero;
                    break;
                case "Metroid Fusion":
                    Pic_Caratulas.Image = Properties.Resources.Gba_Metroid_fusion;
                    break;
            }
        }
    }
}