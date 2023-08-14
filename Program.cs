namespace IntegerDataTypes
{
    /// <summary>
    /// Integer (Tam Sayı) Veri Tipi Ders Kodu
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Veri Türlerinizi Gösterir
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            int age = 21;
            int toplamOynananSaniye = 100;
            const int DakikaBasinaSaniye = 60;

            //oynanan dakikaları ve saniyeleri hesaplayın

            int oynananDakika = toplamOynananSaniye / DakikaBasinaSaniye;
            int oynananSaniye = toplamOynananSaniye % DakikaBasinaSaniye;

            //oynanan dakikaları ve saniyeleri yazdır
            Console.WriteLine("Oynanan Dakika: " +  oynananDakika);
            Console.WriteLine("Oynanan Saniye: " + oynananSaniye);
            Console.WriteLine("benim yasim: " + age);
        }
    }
}