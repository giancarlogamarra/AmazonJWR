using Microsoft.EntityFrameworkCore.Migrations;

namespace Amazon.Migrations
{
    public partial class UpdateCategoryColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Technology
            //History
            //Education
            //Health

            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "519FAE66-69DE-433E-7BAE-08D6DBEB9AD1",
            column: "Category",
            value: "Technology");

            migrationBuilder.UpdateData(
           table: "Books",
           keyColumn: "BookId",
           keyValue: "3BFEE737-ACC1-4A09-7BAF-08D6DBEB9AD1",
           column: "Category",
           value: "Technology");

            migrationBuilder.UpdateData(
          table: "Books",
          keyColumn: "BookId",
          keyValue: "75C632A5-7016-4263-7BB0-08D6DBEB9AD1",
          column: "Category",
          value: "History");

            migrationBuilder.UpdateData(
        table: "Books",
        keyColumn: "BookId",
        keyValue: "4D06B119-42F5-4030-7BB1-08D6DBEB9AD1",
        column: "Category",
        value: "History");

            migrationBuilder.UpdateData(
       table: "Books",
       keyColumn: "BookId",
       keyValue: "FA860431-50B9-4DC9-7BB2-08D6DBEB9AD1",
       column: "Category",
       value: "History");

            migrationBuilder.UpdateData(
      table: "Books",
      keyColumn: "BookId",
      keyValue: "42DD8C6F-C5F0-40F4-7BB3-08D6DBEB9AD1",
      column: "Category",
      value: "Education");

            migrationBuilder.UpdateData(
     table: "Books",
     keyColumn: "BookId",
     keyValue: "2A1B2F3A-E60F-484A-7BB4-08D6DBEB9AD1",
     column: "Category",
     value: "Education");

            migrationBuilder.UpdateData(
     table: "Books",
     keyColumn: "BookId",
     keyValue: "39DC6717-A021-4698-7BB5-08D6DBEB9AD1",
     column: "Category",
     value: "Health");

            migrationBuilder.UpdateData(
     table: "Books",
     keyColumn: "BookId",
     keyValue: "9289D774-B4D5-42C5-7BB6-08D6DBEB9AD1",
     column: "Category",
     value: "Health");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "519FAE66-69DE-433E-7BAE-08D6DBEB9AD1",
            column: "Category",
            value: null);

            migrationBuilder.UpdateData(
           table: "Books",
           keyColumn: "BookId",
           keyValue: "3BFEE737-ACC1-4A09-7BAF-08D6DBEB9AD1",
           column: "Category",
           value: null);

            migrationBuilder.UpdateData(
              table: "Books",
              keyColumn: "BookId",
              keyValue: "75C632A5-7016-4263-7BB0-08D6DBEB9AD1",
              column: "Category",
              value: null);

            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "4D06B119-42F5-4030-7BB1-08D6DBEB9AD1",
            column: "Category",
            value: null);

            migrationBuilder.UpdateData(
           table: "Books",
           keyColumn: "BookId",
           keyValue: "FA860431-50B9-4DC9-7BB2-08D6DBEB9AD1",
           column: "Category",
           value: null);

            migrationBuilder.UpdateData(
              table: "Books",
              keyColumn: "BookId",
              keyValue: "42DD8C6F-C5F0-40F4-7BB3-08D6DBEB9AD1",
              column: "Category",
              value: null);

            migrationBuilder.UpdateData(
             table: "Books",
             keyColumn: "BookId",
             keyValue: "2A1B2F3A-E60F-484A-7BB4-08D6DBEB9AD1",
             column: "Category",
             value: null);

            migrationBuilder.UpdateData(
             table: "Books",
             keyColumn: "BookId",
             keyValue: "39DC6717-A021-4698-7BB5-08D6DBEB9AD1",
             column: "Category",
             value: null);

            migrationBuilder.UpdateData(
             table: "Books",
             keyColumn: "BookId",
             keyValue: "9289D774-B4D5-42C5-7BB6-08D6DBEB9AD1",
             column: "Category",
             value: null);
        }
    }
}
