using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FullApp3
{
    public static class PozicijaVelicina
    {
        //vrijednosti forme normalne veličine prilagođava maksimiziranoj formi
        public static int OpcenitoOsX(int vrijednost)
        {
            int NovaVrijednost = vrijednost * Blackjack.MaxOsX / Blackjack.PocetnaOsX;
            return NovaVrijednost;
        }
        public static int OpcenitoOsY(int vrijednost)
        {
            int NovaVrijednost = vrijednost * Blackjack.MaxOsY / Blackjack.PocetnaOsY;
            return NovaVrijednost;
        }

        //..............................................................................................................................
        public static void PrilagodbaButton(Button btn)
        {
            //Prilagođava lokaciju i veličinu buttona
            btn.Size = new Size(PozicijaVelicina.OpcenitoOsX(btn.Size.Width), PozicijaVelicina.OpcenitoOsY(btn.Size.Height));
            btn.Location = new Point(OpcenitoOsX(btn.Location.X), OpcenitoOsY(btn.Location.Y));
        }

        public static void PrilagodbaLabel(Label lbl)
        {
            //Prilagođava lokaciju i veličinu labela
            lbl.Size = new Size(PozicijaVelicina.OpcenitoOsX(lbl.Size.Width), PozicijaVelicina.OpcenitoOsY(lbl.Size.Height));
            lbl.Location = new Point(OpcenitoOsX(lbl.Location.X), OpcenitoOsY(lbl.Location.Y));
        }

        public static void PrilagodbaPictureBox(PictureBox pb)
        {
            //Prilagođava lokaciju i veličinu pictureboxa
            pb.Size = new Size(PozicijaVelicina.OpcenitoOsX(pb.Size.Width), PozicijaVelicina.OpcenitoOsY(pb.Size.Height));
            pb.Location = new Point(OpcenitoOsX(pb.Location.X), OpcenitoOsY(pb.Location.Y));
        }


        //Upravlja pozicijom lblHint koji se koristi kako bi igraču pokazao koja je ruka aktivna.
        public static void LblHintPozicija()
        {
            if(Blackjack.ActivePlayer=="Igrac1")
            {
                Blackjack.lblHint.Location = new Point(Blackjack.lstIgrac1[0].xAxis + 40, Blackjack.lstIgrac1[0].yAxis + 115);
            }
            else if (Blackjack.ActivePlayer == "Igrac2")
            {
                Blackjack.lblHint.Location = new Point(Blackjack.lstIgrac2[0].xAxis + 40, Blackjack.lstIgrac2[0].yAxis + 115);
            }
            else if (Blackjack.ActivePlayer == "Igrac3")
            {
                Blackjack.lblHint.Location = new Point(Blackjack.lstIgrac3[0].xAxis + 40, Blackjack.lstIgrac3[0].yAxis + 115);
            }
            else if (Blackjack.ActivePlayer == "Igrac4")
            {
                Blackjack.lblHint.Location = new Point(Blackjack.lstIgrac4[0].xAxis + 40, Blackjack.lstIgrac4[0].yAxis + 115);
            }
            Blackjack.lblHint.Visible = true;
        }
    }
}
