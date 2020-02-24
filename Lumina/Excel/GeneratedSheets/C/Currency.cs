namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Currency", columnHash: 0x072e6fd8 )]
    public class Currency : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Item
         *  type: 
         */

        /* offset: 0008 col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0009 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 3
         *  name: Limit
         *  type: 
         */

        /* offset: 000a col: 4
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public uint Item;

        // col: 03 offset: 0004
        public uint Limit;

        // col: 01 offset: 0008
        public byte unknown8;

        // col: 02 offset: 0009
        public byte unknown9;

        // col: 04 offset: 000a
        private byte packeda;
        public bool packeda_1 => ( packeda & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Item = parser.ReadOffset< uint >( 0x0 );

            // col: 3 offset: 0004
            Limit = parser.ReadOffset< uint >( 0x4 );

            // col: 1 offset: 0008
            unknown8 = parser.ReadOffset< byte >( 0x8 );

            // col: 2 offset: 0009
            unknown9 = parser.ReadOffset< byte >( 0x9 );

            // col: 4 offset: 000a
            packeda = parser.ReadOffset< byte >( 0xa );


        }
    }
}