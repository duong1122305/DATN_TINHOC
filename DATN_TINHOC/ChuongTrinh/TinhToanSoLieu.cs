using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_TINHOC.ChuongTrinh
{
    public static class TinhToanSoLieu
    {
        public static void Tinhascotnendungtam(double b, double h, double L, double N, double Rb, double Rsc_Doc, out double Asttdungtam, out double Mttdungtam, out double Muyasdungtam)
        {

            b = b * 1000;
            h = h * 1000;
            L = L * 100;
            double imin;
            if (b < h) imin = 0.288 * b / 10;
            else imin = 0.288 * h / 10;
            double lamda = (L * 0.7) / imin;
            double phi;
            if (lamda <= 28) phi = 1;
            else phi = 1.028 - (0.0000288 * lamda * lamda) - (0.0016 * lamda);
            Asttdungtam = Math.Round((Math.Abs((((N * 1000 / phi) - (Rb * b * h)) / Rsc_Doc) / 100)), 2);
            Mttdungtam = 0;
            Muyasdungtam = (100 * Asttdungtam / (b * h)) * 100;
        }
        public static void Tinhascotlechtamphang(double b, double h, double L, double a, double Mx, double My, double N, double Rb, double Eb, double Es_Doc, double Rs_Doc, double Rsc_Doc, double alpha_R, out double Asttlechtam, out double Mttlechtam, out double Muyaslechtam)
        {
            b = b * 1000;
            h = h * 1000;
            L = L * 1000;
            a = a * 1000;
            if (Mx > My) Mttlechtam = Mx;
            else Mttlechtam = My;
            double e1 = Mttlechtam / N;
            double ea = Math.Max(L / 600, h / 30);
            double e0 = Math.Max(e1, ea);
            double l0 = L * 0.7;
            double lamda = l0 / h;
            double h0 = h - a;
            double hesouondoc;
            if (lamda <= 8) hesouondoc = 1;
            else
            {
                double J = (b * h * h * h) / 12;
                double theta = (0.2 * e0 + 1.05 * h) / (1.5 * e0 + h);
                double Ncr = (2.5 * theta * Eb * J / (l0 * l0));
                hesouondoc = 1 / (1 - N / Ncr);
            }
            double e = hesouondoc * e0 + h / 2 - a;
            double x1 = N * 1000 / (Rb * b);
            double x;
            if (x1 <= alpha_R * h0)
            {
                if (x1 >= 2 * a)
                {
                    x = x1;
                    Asttlechtam = Math.Round((Math.Abs((N * 1000 * e - Rb * b * x * (h0 - x / 2)) / (Rsc_Doc * (h0 - a)) / 100)), 2);
                    Muyaslechtam = (100 * 2 * Asttlechtam / (b * h)) * 100;
                }
                else
                {
                    Asttlechtam = Math.Round((Math.Abs((N * 1000 * (e - (h0 - a)) / (Rs_Doc * (h0 - a))) / 100)), 2);
                    Muyaslechtam = (100 * 2 * Asttlechtam / (b * h)) * 100;
                }
            }
            else
            {
                double epsilon = e0 / h0;
                x = Math.Round((alpha_R + ((1 - alpha_R) / (1 + 50 * epsilon * epsilon))), 2);
                Asttlechtam = Math.Round((Math.Abs((N * 1000 * e - Rb * b * x * (h0 - x / 2)) / (Rsc_Doc * (h0 - a))) / 100), 2);
                Muyaslechtam = (100 * 2 * Asttlechtam / (b * h)) * 100;
            }
        }
        public static void XacDinhAlphaR(string _macBT, string _macdoc, out double Alpha_R)
        {
            Alpha_R = 0;
            if (_macdoc == "CB300-V")
            {
                switch (_macBT)
                {
                    case "B12.5":
                        Alpha_R = 0.449;
                        break;
                    case "B15":
                        Alpha_R = 0.446;
                        break;
                    case "B20":
                        Alpha_R = 0.437;
                        break;
                    case "B25":
                        Alpha_R = 0.427;
                        break;
                    case "B30":
                        Alpha_R = 0.419;
                        break;
                    case "B35":
                        Alpha_R = 0.41;
                        break;
                    case "B40":
                        Alpha_R = 0.4;
                        break;
                }
            }
            else if (_macdoc == "CB400-V")
            {
                switch (_macBT)
                {
                    case "B12.5":
                        Alpha_R = 0.442;
                        break;
                    case "B15":
                        Alpha_R = 0.439;
                        break;
                    case "B20":
                        Alpha_R = 0.429;
                        break;
                    case "B25":
                        Alpha_R = 0.418;
                        break;
                    case "B30":
                        Alpha_R = 0.409;
                        break;
                    case "B35":
                        Alpha_R = 0.399;
                        break;
                    case "B40":
                        Alpha_R = 0.39;
                        break;
                }
            }
            else if (_macdoc == "CB500-V")
            {
                switch (_macBT)
                {
                    case "B12.5":
                        Alpha_R = 0.431;
                        break;
                    case "B15":
                        Alpha_R = 0.427;
                        break;
                    case "B20":
                        Alpha_R = 0.416;
                        break;
                    case "B25":
                        Alpha_R = 0.405;
                        break;
                    case "B30":
                        Alpha_R = 0.395;
                        break;
                    case "B35":
                        Alpha_R = 0.384;
                        break;
                    case "B40":
                        Alpha_R = 0.374;
                        break;
                }
            }
        }
        public static void TachText(string _texts, out double _soluongthep, out double _dkthep)
        {
            string[] texts = _texts.Split('Ø');
            _soluongthep = Convert.ToDouble(texts[0]);
            _dkthep = Convert.ToDouble(texts[1]);
        }
        public static void TinhAs(double _soluongthep, double _dkthep, out double _Asbotri)
        {
            _Asbotri = 0;
            _Asbotri = Math.Round(((_soluongthep * (((_dkthep / 2) * (_dkthep / 2) * 3.14) / 1)) / 100), 2);
        }
    }
}
