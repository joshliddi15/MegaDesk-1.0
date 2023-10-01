namespace MegaDesk_1._0
{
    internal class Desk
    {
        public double deskWidth;
        public double deskDepth;
        public int deskDrawerCnt;
        public desktopMatl deskMatl;
        public int deskWidthMax = 96;
        public int deskDepthMax = 48;
        public int deskWidthMin = 24;
        public int deskDepthMin = 12;
    }

    public enum desktopMatl
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    }

    /* Example of how to get wood price from enum
     
     * WoodType wood = WoodType.Oak;
     * int price = (int)wood;
     * Console.WriteLine($"{wood} costs ${price}");
     
     */
}
