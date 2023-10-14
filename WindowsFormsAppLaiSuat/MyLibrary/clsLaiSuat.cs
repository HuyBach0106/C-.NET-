namespace MyLibrary
{
    public class clsLaiSuat
    {
        public static double TinhLaiSuat(long SoTienVay)
        {
            double MucLaiSuat = 0;
            if (SoTienVay < 5000)
            {
                // Console.WriteLine("Không cho vay");
                MucLaiSuat = 0;
            }
            else if (SoTienVay < 100000)
            {
                MucLaiSuat = 10.5F;
            }
            else if (SoTienVay < 250000)
            {
                MucLaiSuat = 10;
            }
            else if (SoTienVay < 500000)
            {
                MucLaiSuat = 9.5F;
            }
            else
            {
                MucLaiSuat = 9;
            }
            return MucLaiSuat;
        }
    }
}