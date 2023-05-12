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
        #region Arreglos y lista
        #region Nintendo
        Videojuego[] Consolas_nes,Consolas_snes,Consolas_n64,Consolas_gb,Consolas_gba;
        List<Consola> Lista_videojuegos_carrito;
        #endregion
        #region consolas

        #region Nes
        Videojuego Nes_Super_mario_bros,Nes_Super_mario_bros_3,Nes_Mega_man_1,Nes_Mega_man_2,Nes_Metroid,Nes_Kirby_adventure,Nes_The_legend_of_zelda,Nes_Castlevania,Nes_Castlevania_3,Nes_Kid_ikarus,Nes_Earthbound,Nes_Bomberman,Nes_Pounch_out,Nes_Contra,Nes_Battletoads;
        #endregion

        #region Snes
        Videojuego Snes_Super_mario_word,Snes_Crono_triger,Snes_Street_fighter_3,Snes_Super_mario_kart,Snes_Mega_man_x,Snes_Kirby_super_star,Snes_The_legend_of_zelda_a_link_to_the_past,Snes_Super_Castlevania_4,Snes_Super_metroid,Snes_Donkey_Kong_country,Snes_Earthbound_2,Snes_Super_Bomberman,Snes_Yoshis_island,Snes_FZero,Snes_Super_gouls_n_ghost;
        #endregion

        #region N64
        Videojuego N64_Mario_party,N64_Perfect_dark,N64_Donkey_kong_64,N64_Mario_tenis,N64_Doom_64,N64_Kirby_stars_64,N64_The_legend_of_zelda_majora_mask,N64_The_legend_of_zelda_ocarina_of_time,N64_Super_mario_64,N64_Paper_mario,N64_Pokemon_stadium,N64_Mario_kart_64,N64_Star_fox_64,N64_Bnajo_kazooie,N64_Super_smash_bros;
        #endregion

        #region Gb
        Videojuego Gb_Donkey_kong,Gb_Catlevania_2_belmonts_revege,Gb_Metroid_2,Gb_Wario_land,Gb_Pokemon_amarillo,Gb_Pokemon_rojo,Gb_The_legend_of_zelda_oracle_of_seasons,Gb_Super_mario_land,Gb_The_legend_of_zelda_links_awakening,Gb_The_legend_of_zelda_oracle_of_ages,Gb_Super_mario_land_2,Gb_Mega_man_V,Gb_Mario_tennis,Gb_Kirbys_dream_land_2,Gb_Final_Fantasy_Adventure;
        #endregion

        #region Gba
        Videojuego Gba_Mario_y_luigi_super_satar_saga,Gba_The_legend_of_zelda_minish_cap,Gba_Wario_land_4,Gba_Mega_Man_Zero_3,Gba_Metroid_zero_mission,Gba_Pokemon_esmeralda,Gba_Kirby_y_el_laberinto_de_los_espejos,Gba_Castlevania_Aria_of_srrow,Gba_Castlevania_circle_of_the_moon,Gba_Earthbound_3,Gba_Super_mario_advance_4,Gba_Super_mario_world,Gba_Yoshis_island_remake,Gba_Mega_Man_Zero,Gba_Metroid_fusion;
        #endregion

        #endregion
        #endregion
        string music;
        int accountan, Compra_final, Ticket_quantity = 0;
        double Compra_final_iva = 0;
        bool filtro_nes, filtro_snes, filtro_gb, filtro_n64, filtro_gba;
        public From_NintenShop()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            music = @"C:\Users\Israe\Documents\Trabajos de la Universidad\personal\App_NintenShop\App_NintenShop\Resources\NintenShop.wav";
            SoundPlayer player = new SoundPlayer(music);
            player.PlayLooping();
            Lista_videojuegos_carrito = new List<Consola>();
            #region inicializacion de matrizes
            #region //Consolas
            Consolas_nes = new Videojuego[15];
            Consolas_snes = new Videojuego[15];
            Consolas_n64 = new Videojuego[15];
            Consolas_gb = new Videojuego[15];
            Consolas_gba = new Videojuego[15];
            #endregion

            #region Videojuegos_nes
            Nes_Super_mario_bros = new Videojuego("Super Mario Bros", "Plataformas", "Shigeru Miyamoto", 30, "NES", 1985, 8, 1);
            Consolas_nes[0] = Nes_Super_mario_bros;
            Nes_Super_mario_bros_3 = new Videojuego("Super Mario Bros 3", "Plataformas", "Shigeru Miyamoto", 40, "NES", 1988, 8, 1);
            Consolas_nes[1] = Nes_Super_mario_bros_3;
            Nes_Mega_man_1 = new Videojuego("Mega Man", "Plataformas", "Akira Kitamura", 50, "NES", 1987, 8, 1);
            Consolas_nes[2] = Nes_Mega_man_1;
            Nes_Mega_man_2 = new Videojuego("Mega Man 2", "Plataformas", "Akira Kitamura", 60, "NES", 1988, 8, 1);
            Consolas_nes[3] = Nes_Mega_man_2;
            Nes_Metroid = new Videojuego("Metroid", "Aventura", "Hiroji Kiyotake", 40, "NES", 1986, 8, 1);
            Consolas_nes[4] = Nes_Metroid;
            Nes_Kirby_adventure = new Videojuego("Kirby's Adventure", "Plataformas", "Masahiro Sakurai", 50, "NES", 1993, 8, 1);
            Consolas_nes[5] = Nes_Kirby_adventure;
            Nes_The_legend_of_zelda = new Videojuego("The Legend of Zelda", "Aventura", "Shigeru Miyamoto", 50, "NES", 1986, 8, 1);
            Consolas_nes[6] = Nes_The_legend_of_zelda;
            Nes_Castlevania = new Videojuego("Castlevania", "Plataformas", "Hitoshi Akamatsu", 30, "NES", 1986, 8, 1);
            Consolas_nes[7] = Nes_Castlevania;
            Nes_Castlevania_3 = new Videojuego("Castlevania III: Dracula's Curse", "Plataformas", "Jun Funahashi", 40, "NES", 1989, 8, 1);
            Consolas_nes[8] = Nes_Castlevania_3;
            Nes_Kid_ikarus = new Videojuego("Kid Icarus", "Aventura", "Toru Osawa", 50, "NES", 1986, 8, 1);
            Consolas_nes[9] = Nes_Kid_ikarus;
            Nes_Earthbound = new Videojuego("EarthBound Beginnings", "RPG", "Shigesato Itoi", 100, "NES", 1989, 8, 1);
            Consolas_nes[10] = Nes_Earthbound;
            Nes_Bomberman = new Videojuego("Bomberman", "Puzzle", "Shinichi Nakamoto", 40, "NES", 1985, 8, 1);
            Consolas_nes[11] = Nes_Bomberman;
            Nes_Pounch_out = new Videojuego("Punch-Out!!", "Deportes", "Genyo Takeda", 30, "NES", 1987, 8, 1);
            Consolas_nes[12] = Nes_Pounch_out;
            Nes_Contra = new Videojuego("Contra", "Plataformas", "Kazuhisa Hashimoto", 40, "NES", 1987, 8, 1);
            Consolas_nes[13] = Nes_Contra;
            Nes_Battletoads = new Videojuego("Battletoads", "Plataformas", "Rare Ltd.", 60, "NES", 1991, 8, 1);
            Consolas_nes[14] = Nes_Battletoads;
            #endregion

            #region Videojuegos_snes
            Snes_Super_mario_word = new Videojuego("Super Mario World", "Plataformas", "Shigeru Miyamoto", 50, "SNES", 1990, 16, 1);
            Consolas_snes[0] = Snes_Super_mario_word;
            Snes_Crono_triger = new Videojuego("Chrono Trigger", "RPG", "Yuji H, Akira Toriyama y Hironobu S", 200, "SNES", 1995, 16, 1);
            Consolas_snes[1] = Snes_Crono_triger;
            Snes_Street_fighter_3 = new Videojuego("Street Fighter II: Turbo", "Lucha", "Akira Nishitani, Akira Yasuda", 30, "SNES", 1993, 16, 1);
            Consolas_snes[2] = Snes_Street_fighter_3;
            Snes_Super_mario_kart = new Videojuego("Super Mario Kart", "Carreras", "Shigeru Miyamoto", 80, "SNES", 1992, 16, 1);
            Consolas_snes[3] = Snes_Super_mario_kart;
            Snes_Mega_man_x = new Videojuego("Mega Man X", "Plataformas", "Keiji Inafune", 120, "SNES", 1993, 16, 1);
            Consolas_snes[4] = Snes_Mega_man_x;
            Snes_Kirby_super_star = new Videojuego("Kirby Super Star", "Plataformas", "Masahiro Sakurai", 70, "SNES", 1996, 16, 1);
            Consolas_snes[5] = Snes_Kirby_super_star;
            Snes_The_legend_of_zelda_a_link_to_the_past = new Videojuego("The Legend of Zelda: A Link to the Past", "Aventura", "Shigeru Miyamoto", 150, "SNES", 1992, 16, 1);
            Consolas_snes[6] = Snes_The_legend_of_zelda_a_link_to_the_past;
            Snes_Super_Castlevania_4 = new Videojuego("Super Castlevania IV", "Plataformas", "Tomoya T, Masanori A. y Masahiro U", 90, "SNES", 1991, 16, 1);
            Consolas_snes[7] = Snes_Super_Castlevania_4;
            Snes_Super_metroid = new Videojuego("Super Metroid", "Aventura/Acción", "Nintendo R&D1", 70, "SNES", 1994, 16, 1);
            Consolas_snes[8] = Snes_Super_metroid;
            Snes_Donkey_Kong_country = new Videojuego("Donkey Kong Country", "Plataformas", "Rare", 50, "SNES", 1994, 16, 1);
            Consolas_snes[9] = Snes_Donkey_Kong_country;
            Snes_Earthbound_2 = new Videojuego("Mother 2 (EarthBound)", "RPG", "Ape Inc., HAL Laboratory", 150, "SNES", 1995, 16, 1);
            Consolas_snes[10] = Snes_Earthbound_2;
            Snes_Super_Bomberman = new Videojuego("Super Bomberman", "Puzzle", "Hudson Soft", 30, "SNES", 1993, 16, 1);
            Consolas_snes[11] = Snes_Super_Bomberman;
            Snes_Yoshis_island = new Videojuego("Yoshi's Island", "Plataformas", "Nintendo EAD", 60, "SNES", 1995, 16, 1);
            Consolas_snes[12] = Snes_Yoshis_island;
            Snes_FZero = new Videojuego("F-Zero", "Carreras", "Nintendo EAD", 40, "SNES", 1990, 16, 1);
            Consolas_snes[13] = Snes_FZero;
            Snes_Super_gouls_n_ghost = new Videojuego("Super Ghouls 'n Ghosts", "Plataformas", "Capcom", 60, "SNES", 1991, 16, 1);
            Consolas_snes[14] = Snes_Super_gouls_n_ghost;
            #endregion

            #region Videojuegos_n64
            N64_Mario_party = new Videojuego("Mario Party", "Party", "Hudson Soft", 30, "N64", 1998, 64, 1);
            Consolas_n64[0] = N64_Mario_party;
            N64_Perfect_dark = new Videojuego("Perfect Dark", "First-person shooter", "Rare", 30, "N64", 2000, 64, 1);
            Consolas_n64[1] = N64_Perfect_dark;
            N64_Donkey_kong_64 = new Videojuego("Donkey Kong 64", "Plataformas", "Rare", 30, "N64", 1999, 64, 1);
            Consolas_n64[2] = N64_Donkey_kong_64;
            N64_Mario_tenis = new Videojuego("Mario Tennis", "Deportes", "Camelot Software Planning", 30, "N64", 2000, 64, 1);
            Consolas_n64[3] = N64_Mario_tenis;
            N64_Doom_64 = new Videojuego("Doom 64", "First-person shooter", "Midway Games", 30, "N64", 1997, 64, 1);
            Consolas_n64[4] = N64_Doom_64;
            N64_Kirby_stars_64 = new Videojuego("Kirby 64: The Crystal Shards", "Plataformas", "HAL Laboratory", 30, "N64", 2000, 64, 1);
            Consolas_n64[5] = N64_Kirby_stars_64;
            N64_The_legend_of_zelda_majora_mask = new Videojuego("The Legend of Zelda: Majora's Mask", "Aventura", "Nintendo EAD", 30, "N64", 2000, 64, 1);
            Consolas_n64[6] = N64_The_legend_of_zelda_majora_mask;
            N64_The_legend_of_zelda_ocarina_of_time = new Videojuego("The Legend of Zelda: Ocarina of Time", "Aventura", "Nintendo EAD", 30, "N64", 1998, 64, 1);
            Consolas_n64[7] = N64_The_legend_of_zelda_ocarina_of_time;
            N64_Super_mario_64 = new Videojuego("Super Mario 64", "Plataformas", "Nintendo EAD", 30, "N64", 1996, 64, 1);
            Consolas_n64[8] = N64_Super_mario_64;
            N64_Paper_mario = new Videojuego("Paper Mario", "RPG", "Intelligent Systems", 30, "N64", 2001, 64, 1);
            Consolas_n64[9] = N64_Paper_mario;
            N64_Pokemon_stadium = new Videojuego("Pokémon Stadium", "Estrategia", "Nintendo EAD", 30, "N64", 1999, 64, 1);
            Consolas_n64[10] = N64_Pokemon_stadium;
            N64_Mario_kart_64 = new Videojuego("Mario Kart 64", "Carreras", "Nintendo EAD", 30, "N64", 1996, 64, 1);
            Consolas_n64[11] = N64_Mario_kart_64;
            N64_Star_fox_64 = new Videojuego("Star Fox 64", "Simulación de combate espacial", "Nintendo EAD", 30, "N64", 1997, 64, 1);
            Consolas_n64[12] = N64_Star_fox_64;
            N64_Bnajo_kazooie = new Videojuego("Banjo-Kazooie", "Plataformas", "Gregg Mayles", 40, "Nintendo 64", 1998, 64, 1);
            Consolas_n64[13] = N64_Bnajo_kazooie;
            N64_Super_smash_bros = new Videojuego("Super Smash Bros", "Lucha", "Masahiro Sakurai", 45, "Nintendo 64", 1999, 64, 1);
            Consolas_n64[14] = N64_Super_smash_bros;
            #endregion

            #region Videojuegos_gb
            Gb_Donkey_kong = new Videojuego("Donkey Kong", "Plataformas", "Nintendo R&D1", 20, "Game Boy", 1994, 8, 1);
            Consolas_gb[0] = Gb_Donkey_kong;
            Gb_Catlevania_2_belmonts_revege = new Videojuego("Castlevania II: Belmont's Revenge", "Aventura/Plataformas", "Konami", 12, "Game Boy", 1991, 8, 1);
            Consolas_gb[1] = Gb_Catlevania_2_belmonts_revege;
            Gb_Metroid_2 = new Videojuego("Metroid II: Return of Samus", "Aventura/Plataformas", "Nintendo R&D1", 15, "Game Boy", 1991, 8, 1);
            Consolas_gb[2] = Gb_Metroid_2;
            Gb_Wario_land = new Videojuego("Wario Land: Super Mario Land 3", "Plataformas", "Nintendo R&D1", 25, "Game Boy", 1994, 8, 1);
            Consolas_gb[3] = Gb_Wario_land;
            Gb_Pokemon_amarillo = new Videojuego("Pokémon Amarillo", "RPG", "Game Freak", 35, "Game Boy", 1999, 8, 1);
            Consolas_gb[4] = Gb_Pokemon_amarillo;
            Gb_Pokemon_rojo = new Videojuego("Pokémon Rojo", "RPG", "Game Freak", 30, "Game Boy", 1998, 8, 1);
            Consolas_gb[5] = Gb_Pokemon_rojo;
            Gb_The_legend_of_zelda_oracle_of_seasons = new Videojuego("The Legend of Zelda: Oracle of Seasons", "Aventura/RPG", "Capcom", 30, "Game Boy Color", 2001, 8, 1);
            Consolas_gb[6] = Gb_The_legend_of_zelda_oracle_of_seasons;
            Gb_Super_mario_land = new Videojuego("Super Mario Land", "Plataformas", "Nintendo R&D1", 15, "Game Boy", 1989, 8, 1);
            Consolas_gb[7] = Gb_Super_mario_land;
            Gb_The_legend_of_zelda_links_awakening = new Videojuego("The Legend of Zelda: Link's Awakening", "Aventura/RPG", "Nintendo EAD", 25, "Game Boy", 1993, 8, 1);
            Consolas_gb[8] = Gb_The_legend_of_zelda_links_awakening;
            Gb_The_legend_of_zelda_oracle_of_ages = new Videojuego("The Legend of Zelda: Oracle of Ages", "Aventura/RPG", "Capcom", 30, "Game Boy Color", 2001, 8, 1);
            Consolas_gb[9] = Gb_The_legend_of_zelda_oracle_of_ages;
            Gb_Super_mario_land_2 = new Videojuego("Super mario land 2", "Plataformas", "Nintendo R&D1", 20, "Game Boy Color", 1998, 8, 1);
            Consolas_gb[10] = Gb_Super_mario_land_2;
            Gb_Mega_man_V = new Videojuego("Mega Man V", "Plataformas/Acción", "Capcom", 20, "Game Boy", 1994, 8, 1);
            Consolas_gb[11] = Gb_Mega_man_V;
            Gb_Mario_tennis = new Videojuego("Mario Tennis", "Deportes", "Nintendo R&D1", 30, "Game Boy", 1995, 8, 1);
            Consolas_gb[12] = Gb_Mario_tennis;
            Gb_Kirbys_dream_land_2 = new Videojuego("Kirby's Dream Land 2", "Plataformas", "Shinichi Shimomura", 30, "Game Boy", 1995, 8, 1);
            Consolas_gb[13] = Gb_Kirbys_dream_land_2;
            Gb_Final_Fantasy_Adventure = new Videojuego("Final Fantasy Adventure", "Rol", "Koichi Ishii", 30, "Game Boy", 1991, 8, 1);
            Consolas_gb[14] = Gb_Final_Fantasy_Adventure;
            #endregion

            #region Videojuegos_gba
            Gba_Mario_y_luigi_super_satar_saga = new Videojuego("Mario & Luigi: Superstar Saga", "RPG", "AlphaDream", 40, "GBA", 2003, 32, 1);
            Consolas_gba[0] = Gba_Mario_y_luigi_super_satar_saga;
            Gba_The_legend_of_zelda_minish_cap = new Videojuego("The Legend of Zelda: The Minish Cap", "Acción-aventura", "Capcom", 40, "GBA", 2004, 32, 1);
            Consolas_gba[1] = Gba_The_legend_of_zelda_minish_cap;
            Gba_Wario_land_4 = new Videojuego("Wario Land 4", "Plataformas", "Nintendo R&D1", 30, "GBA", 2001, 32, 1);
            Consolas_gba[2] = Gba_Wario_land_4;
            Gba_Mega_Man_Zero_3 = new Videojuego("Mega Man Zero 3", "Plataformas", "Capcom", 45, "GBA", 2004, 32, 1);
            Consolas_gba[3] = Gba_Mega_Man_Zero_3;
            Gba_Metroid_zero_mission = new Videojuego("Metroid Zero Mission", "Acción-aventura", "Nintendo R&D1", 30, "GBA", 2004, 32, 1);
            Consolas_gba[4] = Gba_Metroid_zero_mission;
            Gba_Pokemon_esmeralda = new Videojuego("Pokemon Esmeralda", "RPG", "Game Freak", 40, "GBA", 2005, 32, 1);
            Consolas_gba[5] = Gba_Pokemon_esmeralda;
            Gba_Kirby_y_el_laberinto_de_los_espejos = new Videojuego("Kirby y el Laberinto de los Espejos", "Plataformas", "HAL Laboratory", 30, "GBA", 2004, 32, 1);
            Consolas_gba[6] = Gba_Kirby_y_el_laberinto_de_los_espejos;
            Gba_Castlevania_Aria_of_srrow = new Videojuego("Castlevania: Aria of Sorrow", "Acción-aventura", "Konami", 40, "GBA", 2003, 32, 1);
            Consolas_gba[7] = Gba_Castlevania_Aria_of_srrow;
            Gba_Castlevania_circle_of_the_moon = new Videojuego("Castlevania: Circle of the Moon", "Acción-aventura", "Konami", 30, "GBA", 2001, 32, 1);
            Consolas_gba[8] = Gba_Castlevania_circle_of_the_moon;
            Gba_Earthbound_3 = new Videojuego("Mother 3", "RPG", "Brownie Brown", 40, "GBA", 2006, 32, 1);
            Consolas_gba[9] = Gba_Earthbound_3;
            Gba_Super_mario_advance_4 = new Videojuego("Super Mario Advance 4: Super Mario Bros 3", "Plataformas", "Nintendo R&D2", 30, "GBA", 2003, 32, 1);
            Consolas_gba[10] = Gba_Super_mario_advance_4;
            Gba_Super_mario_world = new Videojuego("Super Mario World: Super Mario Advance 2", "Plataformas", "Nintendo EAD", 30, "GBA", 2002, 32, 1);
            Consolas_gba[11] = Gba_Super_mario_world;
            Gba_Yoshis_island_remake = new Videojuego("Yoshi's Island: Super Mario Advance 3", "Plataformas", "Nintendo", 25, "GBA", 2002, 32, 1);
            Consolas_gba[12] = Gba_Yoshis_island_remake;
            Gba_Mega_Man_Zero = new Videojuego("Mega Man Zero", "Plataformas", "Capcom", 40, "GBA", 2003, 32, 1);
            Consolas_gba[13] = Gba_Mega_Man_Zero;
            Gba_Metroid_fusion = new Videojuego("Metroid Fusion", "Acción, aventura", "Nintendo R&D1", 30, "GBA", 2002, 32, 1);
            Consolas_gba[14] = Gba_Metroid_fusion;
            #endregion
            #endregion
            #region booleanos
            filtro_nes = false;
            filtro_snes = false;
            filtro_gb = false;
            filtro_n64 = false;
            filtro_gba = false;
            #endregion
        }
        public void Btm_filter_nes_Click(object sender, EventArgs e)
		{
            filtro_nes = true;
            filtro_snes = false;
            filtro_gb = false;
            filtro_n64 = false;
            filtro_gba = false;
            if (filtro_nes != false)
            {
                List_juegos.Items.Clear();
                foreach (Consola consola in Consolas_nes)
                {
                    if (consola is Videojuego videojuego)
                    {
                        List_juegos.Items.Add(videojuego.TITLE);
                    }
                }
                List_juegos.SelectedIndex = 0;
                return;
            }
        }

        public void Btm_filter_gb_Click(object sender, EventArgs e)
		{
            filtro_nes = false;
            filtro_snes = false;
            filtro_gb = true;
            filtro_n64 = false;
            filtro_gba = false;
            if (filtro_gb != false)
            {
                List_juegos.Items.Clear();
                foreach (Consola consola in Consolas_gb)
                {
                    if (consola is Videojuego videojuego)
                    {
                        List_juegos.Items.Add(videojuego.TITLE);
                    }
                }
                List_juegos.SelectedIndex = 0;
                return;
            }
        }

        public void Btm_filter_snes_Click(object sender, EventArgs e)
		{
            filtro_nes = false;
            filtro_snes = true;
            filtro_gb = false;
            filtro_n64 = false;
            filtro_gba = false;
            if (filtro_snes != false)
            {
                List_juegos.Items.Clear();
                foreach (Consola consola in Consolas_snes)
                {
                    if (consola is Videojuego videojuego)
                    {
                        List_juegos.Items.Add(videojuego.TITLE);
                    }
                }
                List_juegos.SelectedIndex = 0;
                return;
            }
        }

        public void Btm_filter_n64_Click(object sender, EventArgs e)
		{
            filtro_nes = false;
            filtro_snes = false;
            filtro_gb = false;
            filtro_n64 = true;
            filtro_gba = false;
            if (filtro_n64 != false)
            {
                List_juegos.Items.Clear();
                foreach (Consola consola in Consolas_n64)
                {
                    if (consola is Videojuego videojuego)
                    {
                        List_juegos.Items.Add(videojuego.TITLE);
                    }
                }
                List_juegos.SelectedIndex = 0;
                return;
            }
        }

        public void Btm_filter_gba_Click(object sender, EventArgs e)
		{
            filtro_nes = false;
            filtro_snes = false;
            filtro_gb = false;
            filtro_n64 = false;
            filtro_gba = true;
            if (filtro_gba != false)
            {
                List_juegos.Items.Clear();
                foreach (Consola consola in Consolas_gba)
                {
                    if (consola is Videojuego videojuego)
                    {
                        List_juegos.Items.Add(videojuego.TITLE);
                    }
                }
                List_juegos.SelectedIndex = 0;
                return;
            }
        }

		private void List_juegos_SelectedIndexChanged(object sender, EventArgs e)
		{
            Lista_caratulas();
        }

        private void Btn_comprar_Click(object sender, EventArgs e)
        {
            int selected_game_buy = List_juegos.SelectedIndex;
            if (filtro_nes == true)
            {
                ProcesarCompra(Consolas_nes, selected_game_buy);
            }
            else if(filtro_gb == true)
            {
                ProcesarCompra(Consolas_gb, selected_game_buy);
            }
            else if (filtro_snes == true)
            {
                ProcesarCompra(Consolas_snes, selected_game_buy);
            }
            else if (filtro_n64 == true)
            {
                ProcesarCompra(Consolas_n64, selected_game_buy);
            }
            else
            {
                ProcesarCompra(Consolas_gba, selected_game_buy);
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

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
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
            Panel_carrito_eliminar();
        }

        private void Btn_imprimir_carrito_Click(object sender, EventArgs e)
        {
            if (Lista_videojuegos_carrito.Count > 0)
            {
                Ticket_quantity++;
                string Date_Time_Ticket = DateTime.Now.ToString();
                string Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string Ticket = Path.Combine(Desktop, $"NintenShop {Ticket_quantity}.txt");
                try
                {
                    using (StreamWriter archivo = new StreamWriter(Ticket))
                    {
                        archivo.WriteLine($"NintenShop Inc.                  {Date_Time_Ticket}\n");
                        foreach (Consola consola in Lista_videojuegos_carrito)
                        {
                            archivo.WriteLine(consola.Ticket());
                        }
                        archivo.WriteLine($"Iva: ${Compra_final_iva}.");
                        archivo.WriteLine($"Compra Total: ${Compra_final}.");
                        archivo.WriteLine("\nGracias por comprar en NintenShop Inc.");
                        archivo.Close();
                    }
                    Console.Beep();
                    MessageBox.Show("Ticke impreso exitosamente...");
                    List_carrito.Items.Clear();
                    Lista_videojuegos_carrito.Clear();
                    llbl_compra_iva_carrito.Text = "--";
                    lbl_compra_total_carrito.Text = "--";
                    lbl_contador_carrito.Text = "0";
                    accountan = 0;
                    Compra_final_iva = 0;
                    Compra_final = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al imprimir el ticket..." + ex.Message);
                }
            }
        }

        private void Btn_añadir_carrito_Click(object sender, EventArgs e)
        {
            Comprar_Carrito();
        }

        private void Lista_caratulas()
        {
            int selected_image = List_juegos.SelectedIndex;
            if (filtro_nes == true)
            {
                if (selected_image != -1)
                {
                    Videojuego selected_game = (Videojuego)Consolas_nes[selected_image];
                    switch (selected_game.TITLE)
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
                        default:
                            Pic_Caratulas.Image = null;
                            break;
                    }
                    lbl_titulo.Text = "Título: " + selected_game.TITLE + ".";
                    lbl_genero.Text = "Género: " + selected_game.GENERE + ".";
                    lbl_creadores.Text = "Creador(es): " + selected_game.CREATORS + ".";
                    lbl_año.Text = "Año: " + selected_game.YEAR.ToString() + ".";
                    lbl_consola.Text = "Consola: " + selected_game.CONSOLE + ".";
                    lbl_precio.Text = "$" + selected_game.PRICE.ToString() + ".";
                    lbl_bits.Text = "Bits: " + selected_game.BITS.ToString() + ".";
                }
            }
            else if (filtro_gb == true)
            {
                if (selected_image != -1)
                {
                    Videojuego selected_game = (Videojuego)Consolas_gb[selected_image];
                    switch (selected_game.TITLE)
                    {
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
                        default:
                            Pic_Caratulas.Image = null;
                            break;
                    }
                    lbl_titulo.Text = "Título: " + selected_game.TITLE + ".";
                    lbl_genero.Text = "Género: " + selected_game.GENERE + ".";
                    lbl_creadores.Text = "Creador(es): " + selected_game.CREATORS + ".";
                    lbl_año.Text = "Año: " + selected_game.YEAR.ToString() + ".";
                    lbl_consola.Text = "Consola: " + selected_game.CONSOLE + ".";
                    lbl_precio.Text = "$" + selected_game.PRICE.ToString() + ".";
                    lbl_bits.Text = "Bits: " + selected_game.BITS.ToString() + ".";
                }
            }
            else if (filtro_snes == true)
            {
                if (selected_image != -1)
                {
                    Videojuego selected_game = (Videojuego)Consolas_snes[selected_image];
                    switch (selected_game.TITLE)
                    {
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
                        default:
                            Pic_Caratulas.Image = null;
                            break;
                    }
                    lbl_titulo.Text = "Título: " + selected_game.TITLE + ".";
                    lbl_genero.Text = "Género: " + selected_game.GENERE + ".";
                    lbl_creadores.Text = "Creador(es): " + selected_game.CREATORS + ".";
                    lbl_año.Text = "Año: " + selected_game.YEAR.ToString() + ".";
                    lbl_consola.Text = "Consola: " + selected_game.CONSOLE + ".";
                    lbl_precio.Text = "$" + selected_game.PRICE.ToString() + ".";
                    lbl_bits.Text = "Bits: " + selected_game.BITS.ToString() + ".";
                }
            }
            else if (filtro_n64 == true)
            {
                if (selected_image != -1)
                {
                    Videojuego selected_game = (Videojuego)Consolas_n64[selected_image];
                    switch (selected_game.TITLE)
                    {
                        case "Mario Party":
                            Pic_Caratulas.Image = Properties.Resources.N64_Mario_party;
                            break;
                        case "Perfect Dark":
                            Pic_Caratulas.Image = Properties.Resources.N64_Perfect_dark;
                            break;
                        case "Donkey Kong 64":
                            Pic_Caratulas.Image = Properties.Resources.N64_Donkey_kong_64;
                            break;
                        case "Mario Tennis":
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
                        default:
                            Pic_Caratulas.Image = null;
                            break;
                    }
                    lbl_titulo.Text = "Título: " + selected_game.TITLE + ".";
                    lbl_genero.Text = "Género: " + selected_game.GENERE + ".";
                    lbl_creadores.Text = "Creador(es): " + selected_game.CREATORS + ".";
                    lbl_año.Text = "Año: " + selected_game.YEAR.ToString() + ".";
                    lbl_consola.Text = "Consola: " + selected_game.CONSOLE + ".";
                    lbl_precio.Text = "$" + selected_game.PRICE.ToString() + ".";
                    lbl_bits.Text = "Bits: " + selected_game.BITS.ToString() + ".";
                }
            }
            else if (filtro_gba == true)
            {
                if (selected_image != -1)
                {
                    Videojuego selected_game = (Videojuego)Consolas_gba[selected_image];
                    switch (selected_game.TITLE)
                    {
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
                        default:
                            Pic_Caratulas.Image = null;
                            break;
                    }
                    lbl_titulo.Text = "Título: " + selected_game.TITLE + ".";
                    lbl_genero.Text = "Género: " + selected_game.GENERE + ".";
                    lbl_creadores.Text = "Creador(es): " + selected_game.CREATORS + ".";
                    lbl_año.Text = "Año: " + selected_game.YEAR.ToString() + ".";
                    lbl_consola.Text = "Consola: " + selected_game.CONSOLE + ".";
                    lbl_precio.Text = "$" + selected_game.PRICE.ToString() + ".";
                    lbl_bits.Text = "Bits: " + selected_game.BITS.ToString() + ".";
                }
            }
        }

        private void ProcesarCompra(Videojuego[] videojuegos, int indiceSeleccionado)
        {
            if (indiceSeleccionado != -1)
            {
                Videojuego selected_game = videojuegos[indiceSeleccionado];
                double buy = selected_game.PRICE;
                double IVA = Math.Round((buy / 1.16) * .16, 2);
                buy = Math.Round(buy - IVA, 2);
                double buy_final = buy + IVA;
                Console.Beep();
                MessageBox.Show(
                    $"NintenShop            {DateTime.Now}\n\n"
                    + "Titulo: " + $"{selected_game.TITLE}" + "\n"
                    + "Genero: " + $"{selected_game.GENERE}" + "\n"
                    + "Año: " + $"{selected_game.YEAR}" + "\n"
                    + "Precio: " + $"{selected_game.PRICE}" + "\n\n"
                    + "Iva: " + $"${IVA}" + "\n"
                    + "Total:" + $" ${buy}\n\n"
                    + "Sub Total Final:" + $" ${buy_final}\n"
                    + "Gracias por su compra.");
            }
        }


        private void Comprar_Carrito()
        {
            int shopping_trolley = List_juegos.SelectedIndex;
            if (filtro_nes == true)
            {
                if (shopping_trolley != -1)
                {
                    Videojuego selected_game = (Videojuego)Consolas_nes[shopping_trolley];
                    switch (selected_game.TITLE)
                    {
                        case "Super Mario Bros":
                            if (!Lista_videojuegos_carrito.Contains(Nes_Super_mario_bros))
                            {
                                Lista_videojuegos_carrito.Add(Nes_Super_mario_bros);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Super Mario Bros 3":
                            if (!Lista_videojuegos_carrito.Contains(Nes_Super_mario_bros_3))
                            {
                                Lista_videojuegos_carrito.Add(Nes_Super_mario_bros_3);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Mega Man":
                            if (!Lista_videojuegos_carrito.Contains(Nes_Mega_man_1))
                            {
                                Lista_videojuegos_carrito.Add(Nes_Mega_man_1);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Mega Man 2":
                            if (!Lista_videojuegos_carrito.Contains(Nes_Mega_man_2))
                            {
                                Lista_videojuegos_carrito.Add(Nes_Mega_man_2);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Metroid":
                            if (!Lista_videojuegos_carrito.Contains(Nes_Metroid))
                            {
                                Lista_videojuegos_carrito.Add(Nes_Metroid);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Kirby's Adventure":
                            if (!Lista_videojuegos_carrito.Contains(Nes_Kirby_adventure))
                            {
                                Lista_videojuegos_carrito.Add(Nes_Kirby_adventure);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "The Legend of Zelda":
                            if (!Lista_videojuegos_carrito.Contains(Nes_The_legend_of_zelda))
                            {
                                Lista_videojuegos_carrito.Add(Nes_The_legend_of_zelda);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Castlevania":
                            if (!Lista_videojuegos_carrito.Contains(Nes_Castlevania))
                            {
                                Lista_videojuegos_carrito.Add(Nes_Castlevania);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Castlevania III: Dracula's Curse":
                            if (!Lista_videojuegos_carrito.Contains(Nes_Castlevania_3))
                            {
                                Lista_videojuegos_carrito.Add(Nes_Castlevania_3);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Kid Icarus":
                            if (!Lista_videojuegos_carrito.Contains(Nes_Kid_ikarus))
                            {
                                Lista_videojuegos_carrito.Add(Nes_Kid_ikarus);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "EarthBound Beginnings":
                            if (!Lista_videojuegos_carrito.Contains(Nes_Earthbound))
                            {
                                Lista_videojuegos_carrito.Add(Nes_Earthbound);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Bomberman":
                            if (!Lista_videojuegos_carrito.Contains(Nes_Bomberman))
                            {
                                Lista_videojuegos_carrito.Add(Nes_Bomberman);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Punch-Out!!":
                            if (!Lista_videojuegos_carrito.Contains(Nes_Pounch_out))
                            {
                                Lista_videojuegos_carrito.Add(Nes_Pounch_out);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Contra":
                            if (!Lista_videojuegos_carrito.Contains(Nes_Contra))
                            {
                                Lista_videojuegos_carrito.Add(Nes_Contra);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Battletoads":
                            if (!Lista_videojuegos_carrito.Contains(Nes_Battletoads))
                            {
                                Lista_videojuegos_carrito.Add(Nes_Battletoads);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                    }
                }
            }
            else if (filtro_gb == true)
            {
                if (shopping_trolley != -1)
                {
                    Videojuego selected_game = (Videojuego)Consolas_gb[shopping_trolley];
                    switch (selected_game.TITLE)
                    {
                        case "Donkey Kong":
                            if (!Lista_videojuegos_carrito.Contains(Gb_Donkey_kong))
                            {
                                Lista_videojuegos_carrito.Add(Gb_Donkey_kong);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Castlevania II: Belmont's Revenge":
                            if (!Lista_videojuegos_carrito.Contains(Gb_Catlevania_2_belmonts_revege))
                            {
                                Lista_videojuegos_carrito.Add(Gb_Catlevania_2_belmonts_revege);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Metroid II: Return of Samus":
                            if (!Lista_videojuegos_carrito.Contains(Gb_Metroid_2))
                            {
                                Lista_videojuegos_carrito.Add(Gb_Metroid_2);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Wario Land: Super Mario Land 3":
                            if (!Lista_videojuegos_carrito.Contains(Gb_Wario_land))
                            {
                                Lista_videojuegos_carrito.Add(Gb_Wario_land);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Pokémon Amarillo":
                            if (!Lista_videojuegos_carrito.Contains(Gb_Pokemon_amarillo))
                            {
                                Lista_videojuegos_carrito.Add(Gb_Pokemon_amarillo);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Pokémon Rojo":
                            if (!Lista_videojuegos_carrito.Contains(Gb_Pokemon_rojo))
                            {
                                Lista_videojuegos_carrito.Add(Gb_Pokemon_rojo);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "The Legend of Zelda: Oracle of Seasons":
                            if (!Lista_videojuegos_carrito.Contains(Gb_The_legend_of_zelda_oracle_of_seasons))
                            {
                                Lista_videojuegos_carrito.Add(Gb_The_legend_of_zelda_oracle_of_seasons);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "The Legend of Zelda: Oracle of Ages":
                            if (!Lista_videojuegos_carrito.Contains(Gb_The_legend_of_zelda_oracle_of_ages))
                            {
                                Lista_videojuegos_carrito.Add(Gb_The_legend_of_zelda_oracle_of_ages);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "The Legend of Zelda: Link's Awakening":
                            if (!Lista_videojuegos_carrito.Contains(Gb_The_legend_of_zelda_links_awakening))
                            {
                                Lista_videojuegos_carrito.Add(Gb_The_legend_of_zelda_links_awakening);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Super Mario Land":
                            if (!Lista_videojuegos_carrito.Contains(Gb_Super_mario_land))
                            {
                                Lista_videojuegos_carrito.Add(Gb_Super_mario_land);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Super mario land 2":
                            if (!Lista_videojuegos_carrito.Contains(Gb_Super_mario_land_2))
                            {
                                Lista_videojuegos_carrito.Add(Gb_Super_mario_land_2);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Mega Man V":
                            if (!Lista_videojuegos_carrito.Contains(Gb_Mega_man_V))
                            {
                                Lista_videojuegos_carrito.Add(Gb_Mega_man_V);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Mario Tennis":
                            if (!Lista_videojuegos_carrito.Contains(Gb_Mario_tennis))
                            {
                                Lista_videojuegos_carrito.Add(Gb_Mario_tennis);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Kirby's Dream Land 2":
                            if (!Lista_videojuegos_carrito.Contains(Gb_Kirbys_dream_land_2))
                            {
                                Lista_videojuegos_carrito.Add(Gb_Kirbys_dream_land_2);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Final Fantasy Adventure":
                            if (!Lista_videojuegos_carrito.Contains(Gb_Final_Fantasy_Adventure))
                            {
                                Lista_videojuegos_carrito.Add(Gb_Final_Fantasy_Adventure);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                    }
                }
            }
            else if (filtro_snes == true)
            {
                if (shopping_trolley != -1)
                {
                    Videojuego selected_game = (Videojuego)Consolas_snes[shopping_trolley];
                    switch (selected_game.TITLE)
                    {
                        case "Super Mario World":
                            if (!Lista_videojuegos_carrito.Contains(Snes_Super_mario_word))
                            {
                                Lista_videojuegos_carrito.Add(Snes_Super_mario_word);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Chrono Trigger":
                            if (!Lista_videojuegos_carrito.Contains(Snes_Crono_triger))
                            {
                                Lista_videojuegos_carrito.Add(Snes_Crono_triger);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Street Fighter II: Turbo":
                            if (!Lista_videojuegos_carrito.Contains(Snes_Street_fighter_3))
                            {
                                Lista_videojuegos_carrito.Add(Snes_Street_fighter_3);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Super Mario Kart":
                            if (!Lista_videojuegos_carrito.Contains(Snes_Super_mario_kart))
                            {
                                Lista_videojuegos_carrito.Add(Snes_Super_mario_kart);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Mega Man X":
                            if (!Lista_videojuegos_carrito.Contains(Snes_Mega_man_x))
                            {
                                Lista_videojuegos_carrito.Add(Snes_Mega_man_x);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Kirby Super Star":
                            if (!Lista_videojuegos_carrito.Contains(Snes_Kirby_super_star))
                            {
                                Lista_videojuegos_carrito.Add(Snes_Kirby_super_star);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "The Legend of Zelda: A Link to the Past":
                            if (!Lista_videojuegos_carrito.Contains(Snes_The_legend_of_zelda_a_link_to_the_past))
                            {
                                Lista_videojuegos_carrito.Add(Snes_The_legend_of_zelda_a_link_to_the_past);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Super Castlevania IV":
                            if (!Lista_videojuegos_carrito.Contains(Snes_Super_Castlevania_4))
                            {
                                Lista_videojuegos_carrito.Add(Snes_Super_Castlevania_4);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Super Metroid":
                            if (!Lista_videojuegos_carrito.Contains(Snes_Super_metroid))
                            {
                                Lista_videojuegos_carrito.Add(Snes_Super_metroid);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Donkey Kong Country":
                            if (!Lista_videojuegos_carrito.Contains(Snes_Donkey_Kong_country))
                            {
                                Lista_videojuegos_carrito.Add(Snes_Donkey_Kong_country);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Mother 2 (EarthBound)":
                            if (!Lista_videojuegos_carrito.Contains(Snes_Earthbound_2))
                            {
                                Lista_videojuegos_carrito.Add(Snes_Earthbound_2);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Super Bomberman":
                            if (!Lista_videojuegos_carrito.Contains(Snes_Super_Bomberman))
                            {
                                Lista_videojuegos_carrito.Add(Snes_Super_Bomberman);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Yoshi's Island":
                            if (!Lista_videojuegos_carrito.Contains(Snes_Yoshis_island))
                            {
                                Lista_videojuegos_carrito.Add(Snes_Yoshis_island);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "F-Zero":
                            if (!Lista_videojuegos_carrito.Contains(Snes_FZero))
                            {
                                Lista_videojuegos_carrito.Add(Snes_FZero);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Super Ghouls 'n Ghosts":
                            if (!Lista_videojuegos_carrito.Contains(Snes_Super_gouls_n_ghost))
                            {
                                Lista_videojuegos_carrito.Add(Snes_Super_gouls_n_ghost);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                    }
                }
            }
            else if (filtro_n64 == true)
            {
                if (shopping_trolley != -1)
                {
                    Videojuego selected_game = (Videojuego)Consolas_n64[shopping_trolley];
                    switch (selected_game.TITLE)
                    {
                        case "Mario Party":
                            
                            if (!Lista_videojuegos_carrito.Contains(N64_Mario_party))
                            {
                                Lista_videojuegos_carrito.Add(N64_Mario_party);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Perfect Dark":
                            if (!Lista_videojuegos_carrito.Contains(N64_Perfect_dark))
                            {
                                Lista_videojuegos_carrito.Add(N64_Perfect_dark);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Donkey Kong 64":
                            if (!Lista_videojuegos_carrito.Contains(N64_Donkey_kong_64))
                            {
                                Lista_videojuegos_carrito.Add(N64_Donkey_kong_64);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Mario Tennis":
                            if (!Lista_videojuegos_carrito.Contains(N64_Mario_tenis))
                            {
                                Lista_videojuegos_carrito.Add(N64_Mario_tenis);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Doom 64":
                            if (!Lista_videojuegos_carrito.Contains(N64_Doom_64))
                            {
                                Lista_videojuegos_carrito.Add(N64_Doom_64);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Kirby 64: The Crystal Shards":
                            if (!Lista_videojuegos_carrito.Contains(N64_Kirby_stars_64))
                            {
                                Lista_videojuegos_carrito.Add(N64_Kirby_stars_64);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "The Legend of Zelda: Majora's Mask":
                            if (!Lista_videojuegos_carrito.Contains(N64_The_legend_of_zelda_majora_mask))
                            {
                                Lista_videojuegos_carrito.Add(N64_The_legend_of_zelda_majora_mask);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "The Legend of Zelda: Ocarina of Time":
                            if (!Lista_videojuegos_carrito.Contains(N64_The_legend_of_zelda_ocarina_of_time))
                            {
                                Lista_videojuegos_carrito.Add(N64_The_legend_of_zelda_ocarina_of_time);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Super Mario 64":
                            if (!Lista_videojuegos_carrito.Contains(N64_Super_mario_64))
                            {
                                Lista_videojuegos_carrito.Add(N64_Super_mario_64);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Paper Mario":
                            if (!Lista_videojuegos_carrito.Contains(N64_Paper_mario))
                            {
                                Lista_videojuegos_carrito.Add(N64_Paper_mario);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Pokémon Stadium":
                            if (!Lista_videojuegos_carrito.Contains(N64_Pokemon_stadium))
                            {
                                Lista_videojuegos_carrito.Add(N64_Pokemon_stadium);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Mario Kart 64":
                            if (!Lista_videojuegos_carrito.Contains(N64_Mario_kart_64))
                            {
                                Lista_videojuegos_carrito.Add(N64_Mario_kart_64);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Star Fox 64":
                            if (!Lista_videojuegos_carrito.Contains(N64_Star_fox_64))
                            {
                                Lista_videojuegos_carrito.Add(N64_Star_fox_64);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Banjo-Kazooie":
                            if (!Lista_videojuegos_carrito.Contains(N64_Bnajo_kazooie))
                            {
                                Lista_videojuegos_carrito.Add(N64_Bnajo_kazooie);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Super Smash Bros":
                            if (!Lista_videojuegos_carrito.Contains(N64_Super_smash_bros))
                            {
                                Lista_videojuegos_carrito.Add(N64_Super_smash_bros);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                    }
                }
            }
            else if (filtro_gba == true)
            {
                if (shopping_trolley != -1)
                {
                    Videojuego selected_game = (Videojuego)Consolas_gba[shopping_trolley];
                    switch (selected_game.TITLE)
                    {
                        case "Mario & Luigi: Superstar Saga":
                            if (!Lista_videojuegos_carrito.Contains(Gba_Mario_y_luigi_super_satar_saga))
                            {
                                Lista_videojuegos_carrito.Add(Gba_Mario_y_luigi_super_satar_saga);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "The Legend of Zelda: The Minish Cap":
                            if (!Lista_videojuegos_carrito.Contains(Gba_The_legend_of_zelda_minish_cap))
                            {
                                Lista_videojuegos_carrito.Add(Gba_The_legend_of_zelda_minish_cap);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Wario Land 4":
                            if (!Lista_videojuegos_carrito.Contains(Gba_Wario_land_4))
                            {
                                Lista_videojuegos_carrito.Add(Gba_Wario_land_4);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Mega Man Zero 3":
                            if (!Lista_videojuegos_carrito.Contains(Gba_Mega_Man_Zero_3))
                            {
                                Lista_videojuegos_carrito.Add(Gba_Mega_Man_Zero_3);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Metroid Zero Mission":
                            if (!Lista_videojuegos_carrito.Contains(Gba_Metroid_zero_mission))
                            {
                                Lista_videojuegos_carrito.Add(Gba_Metroid_zero_mission);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Pokemon Esmeralda":
                            if (!Lista_videojuegos_carrito.Contains(Gba_Pokemon_esmeralda))
                            {
                                Lista_videojuegos_carrito.Add(Gba_Pokemon_esmeralda);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Kirby y el Laberinto de los Espejos":
                            if (!Lista_videojuegos_carrito.Contains(Gba_Kirby_y_el_laberinto_de_los_espejos))
                            {
                                Lista_videojuegos_carrito.Add(Gba_Kirby_y_el_laberinto_de_los_espejos);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Castlevania: Aria of Sorrow":
                            if (!Lista_videojuegos_carrito.Contains(Gba_Castlevania_Aria_of_srrow))
                            {
                                Lista_videojuegos_carrito.Add(Gba_Castlevania_Aria_of_srrow);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Castlevania: Circle of the Moon":
                            if (!Lista_videojuegos_carrito.Contains(Gba_Castlevania_circle_of_the_moon))
                            {
                                Lista_videojuegos_carrito.Add(Gba_Castlevania_circle_of_the_moon);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Mother 3":
                            if (!Lista_videojuegos_carrito.Contains(Gba_Earthbound_3))
                            {
                                Lista_videojuegos_carrito.Add(Gba_Earthbound_3);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Super Mario Advance 4: Super Mario Bros 3":
                            if (!Lista_videojuegos_carrito.Contains(Gba_Super_mario_advance_4))
                            {
                                Lista_videojuegos_carrito.Add(Gba_Super_mario_advance_4);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Super Mario World: Super Mario Advance 2":
                            if (!Lista_videojuegos_carrito.Contains(Gba_Super_mario_world))
                            {
                                Lista_videojuegos_carrito.Add(Gba_Super_mario_world);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Yoshi's Island: Super Mario Advance 3":
                            if (!Lista_videojuegos_carrito.Contains(Gba_Yoshis_island_remake))
                            {
                                Lista_videojuegos_carrito.Add(Gba_Yoshis_island_remake);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Mega Man Zero":
                            if (!Lista_videojuegos_carrito.Contains(Gba_Mega_Man_Zero))
                            {
                                Lista_videojuegos_carrito.Add(Gba_Mega_Man_Zero);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                        case "Metroid Fusion":
                            if (!Lista_videojuegos_carrito.Contains(Gba_Metroid_fusion))
                            {
                                Lista_videojuegos_carrito.Add(Gba_Metroid_fusion);
                                accountan++;
                                lbl_contador_carrito.Text = accountan.ToString();
                                Compra_final += (selected_game.PRICE);
                                Compra_final_iva = Math.Round((Compra_final * .16), 2);
                                Panel_carrito_agregar();
                            }
                            break;
                    }
                }
            }
        }

        private void Panel_carrito_agregar()
        {
            Console.Beep();
            Consola consola_agregada = Lista_videojuegos_carrito.Last();
            Videojuego videojuego_agregado = (Videojuego)consola_agregada;
            List_carrito.Items.Add(videojuego_agregado.ToString());
            llbl_compra_iva_carrito.Text = $"${Compra_final_iva.ToString()}" + ".";
            lbl_compra_total_carrito.Text = $"${Compra_final.ToString()}" + ".";
        }

        private void Panel_carrito_eliminar()
        {
            if (List_carrito.SelectedItems.Count == 0)
            {
                return;
            }
            int indiceSeleccionado = List_carrito.SelectedIndices[0];
            Videojuego videojuegoEliminado = (Videojuego)Lista_videojuegos_carrito[indiceSeleccionado];
            Compra_final -= (videojuegoEliminado.PRICE);
            Compra_final_iva -= Math.Round((videojuegoEliminado.PRICE * .16), 2);
            List_carrito.Items.RemoveAt(indiceSeleccionado);
            Lista_videojuegos_carrito.RemoveAt(indiceSeleccionado);
            accountan -= 1;
            llbl_compra_iva_carrito.Text = $"${Math.Round((Compra_final * .16), 2).ToString()}" + ".";
            lbl_compra_total_carrito.Text = $"${Compra_final.ToString()}" + ".";
            lbl_contador_carrito.Text = accountan.ToString();
        }
    }
}