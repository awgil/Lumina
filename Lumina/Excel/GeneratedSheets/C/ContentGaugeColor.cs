namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentGaugeColor", columnHash: 0x96a22aea )]
    public class ContentGaugeColor : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: AndroidColor{1}
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: AndroidColor{2}
         *  type: 
         */

        /* offset: 0008 col: 2
         *  name: AndroidColor{3}
         *  type: 
         */



        // col: 00 offset: 0000
        public uint AndroidColor1;

        // col: 01 offset: 0004
        public uint AndroidColor2;

        // col: 02 offset: 0008
        public uint AndroidColor3;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            AndroidColor1 = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            AndroidColor2 = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            AndroidColor3 = parser.ReadOffset< uint >( 0x8 );


        }
    }
}