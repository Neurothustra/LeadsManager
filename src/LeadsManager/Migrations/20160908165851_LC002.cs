using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LeadsManager.Migrations
{
    public partial class LC002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    DateSynced = table.Column<DateTime>(nullable: false),
                    IsSynced = table.Column<bool>(nullable: true),
                    ad_type = table.Column<string>(maxLength: 255, nullable: true),
                    apartment_name = table.Column<string>(maxLength: 255, nullable: true),
                    citizenship_country = table.Column<string>(maxLength: 255, nullable: true),
                    city = table.Column<string>(maxLength: 255, nullable: true),
                    college_other = table.Column<string>(maxLength: 255, nullable: true),
                    confirm_email = table.Column<string>(maxLength: 255, nullable: true),
                    country = table.Column<string>(maxLength: 255, nullable: true),
                    current_employer = table.Column<string>(maxLength: 255, nullable: true),
                    currently_employed = table.Column<string>(maxLength: 255, nullable: true),
                    date_of_birth = table.Column<string>(maxLength: 255, nullable: true),
                    diploma_or_ged = table.Column<string>(maxLength: 255, nullable: true),
                    email_address = table.Column<string>(maxLength: 255, nullable: true),
                    employer_name = table.Column<string>(maxLength: 255, nullable: true),
                    employer_other = table.Column<string>(maxLength: 255, nullable: true),
                    ethnicity = table.Column<string>(maxLength: 255, nullable: true),
                    first_name = table.Column<string>(maxLength: 255, nullable: true),
                    gender_id = table.Column<string>(maxLength: 255, nullable: true),
                    h_s_graduation_year = table.Column<string>(maxLength: 255, nullable: true),
                    h_s_state = table.Column<string>(maxLength: 255, nullable: true),
                    high_school_name = table.Column<string>(maxLength: 255, nullable: true),
                    highest_level_education = table.Column<string>(maxLength: 255, nullable: true),
                    how_did_you_hear = table.Column<string>(maxLength: 255, nullable: true),
                    how_soon_start = table.Column<string>(maxLength: 255, nullable: true),
                    last_name = table.Column<string>(maxLength: 255, nullable: true),
                    maiden_name = table.Column<string>(maxLength: 255, nullable: true),
                    middle_name = table.Column<string>(maxLength: 255, nullable: true),
                    military_branch = table.Column<string>(maxLength: 255, nullable: true),
                    name_of_event = table.Column<string>(maxLength: 255, nullable: true),
                    name_of_state = table.Column<string>(maxLength: 255, nullable: true),
                    other_country = table.Column<string>(maxLength: 255, nullable: true),
                    previously_attended = table.Column<string>(maxLength: 255, nullable: true),
                    primary_phone = table.Column<string>(maxLength: 255, nullable: true),
                    primary_phone_type = table.Column<string>(maxLength: 255, nullable: true),
                    program_concentration = table.Column<string>(maxLength: 255, nullable: true),
                    program_degree = table.Column<string>(maxLength: 255, nullable: true),
                    programs_interested = table.Column<string>(maxLength: 255, nullable: true),
                    race = table.Column<string>(maxLength: 255, nullable: true),
                    referral_source = table.Column<string>(maxLength: 255, nullable: true),
                    referred_by = table.Column<string>(maxLength: 255, nullable: true),
                    referred_by_whom = table.Column<string>(maxLength: 255, nullable: true),
                    school_name = table.Column<string>(maxLength: 255, nullable: true),
                    secondary_phone = table.Column<string>(maxLength: 255, nullable: true),
                    seconday_phone_type = table.Column<string>(maxLength: 255, nullable: true),
                    social_security = table.Column<string>(maxLength: 255, nullable: true),
                    street_address = table.Column<string>(maxLength: 255, nullable: true),
                    stte = table.Column<string>(maxLength: 255, nullable: true),
                    suffix = table.Column<string>(maxLength: 255, nullable: true),
                    zip_code = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EmailUs",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    DateSynced = table.Column<DateTime>(nullable: false),
                    IsSynced = table.Column<bool>(nullable: true),
                    dropdown_list_field_controller = table.Column<string>(maxLength: 255, nullable: true),
                    pragraph_text_field_controller = table.Column<string>(maxLength: 255, nullable: true),
                    text_field_controller = table.Column<string>(maxLength: 255, nullable: true),
                    text_field_controller_0 = table.Column<string>(maxLength: 255, nullable: true),
                    text_field_controller_1 = table.Column<string>(maxLength: 255, nullable: true),
                    text_field_controller_2 = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailUs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Inquiry",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    DateSynced = table.Column<DateTime>(nullable: false),
                    IsSynced = table.Column<bool>(nullable: true),
                    ad_type = table.Column<string>(maxLength: 255, nullable: true),
                    apartment_number = table.Column<string>(maxLength: 255, nullable: true),
                    city = table.Column<string>(maxLength: 255, nullable: true),
                    confirm_email = table.Column<string>(maxLength: 255, nullable: true),
                    country = table.Column<string>(maxLength: 255, nullable: true),
                    diploma_or_ged = table.Column<string>(maxLength: 255, nullable: true),
                    email_address = table.Column<string>(maxLength: 255, nullable: true),
                    evaluation = table.Column<string>(maxLength: 255, nullable: true),
                    first_name = table.Column<string>(maxLength: 255, nullable: true),
                    how_did_you_hear = table.Column<string>(maxLength: 255, nullable: true),
                    how_soon_start = table.Column<string>(maxLength: 255, nullable: true),
                    last_name = table.Column<string>(maxLength: 255, nullable: true),
                    maiden_name = table.Column<string>(maxLength: 255, nullable: true),
                    middle_name = table.Column<string>(maxLength: 255, nullable: true),
                    military = table.Column<string>(maxLength: 255, nullable: true),
                    name_of_event = table.Column<string>(maxLength: 255, nullable: true),
                    other_country = table.Column<string>(maxLength: 255, nullable: true),
                    previously_attended = table.Column<string>(maxLength: 255, nullable: true),
                    primary_phone = table.Column<string>(maxLength: 255, nullable: true),
                    primary_phone_type = table.Column<string>(maxLength: 255, nullable: true),
                    program_concentration = table.Column<string>(maxLength: 255, nullable: true),
                    program_degree = table.Column<string>(maxLength: 255, nullable: true),
                    programs_interested = table.Column<string>(maxLength: 255, nullable: true),
                    referral_employer = table.Column<string>(maxLength: 255, nullable: true),
                    referral_other_employer = table.Column<string>(maxLength: 255, nullable: true),
                    referral_other_school = table.Column<string>(maxLength: 255, nullable: true),
                    referral_school = table.Column<string>(maxLength: 255, nullable: true),
                    referral_source = table.Column<string>(maxLength: 255, nullable: true),
                    referred_by = table.Column<string>(maxLength: 255, nullable: true),
                    referred_by_whom = table.Column<string>(maxLength: 255, nullable: true),
                    secondary_phone = table.Column<string>(maxLength: 255, nullable: true),
                    secondary_phone_type = table.Column<string>(maxLength: 255, nullable: true),
                    state_name = table.Column<string>(maxLength: 255, nullable: true),
                    street_address = table.Column<string>(maxLength: 255, nullable: true),
                    stte = table.Column<string>(maxLength: 255, nullable: true),
                    suffix = table.Column<string>(maxLength: 255, nullable: true),
                    zip_code = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inquiry", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Leads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(maxLength: 255, nullable: true),
                    Age = table.Column<string>(maxLength: 255, nullable: true),
                    City = table.Column<string>(maxLength: 255, nullable: true),
                    Country = table.Column<string>(maxLength: 255, nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateSynced = table.Column<DateTime>(nullable: true),
                    DesiredStart = table.Column<string>(maxLength: 255, nullable: true),
                    Email = table.Column<string>(maxLength: 255, nullable: true),
                    FirstName = table.Column<string>(maxLength: 255, nullable: true),
                    FormName = table.Column<string>(maxLength: 255, nullable: true),
                    HSGradYear = table.Column<string>(maxLength: 255, nullable: true),
                    HighestEduCompleted = table.Column<string>(maxLength: 255, nullable: true),
                    IsSynced = table.Column<bool>(nullable: true),
                    Key = table.Column<string>(maxLength: 255, nullable: true),
                    LastName = table.Column<string>(maxLength: 255, nullable: true),
                    MilitaryAffiliation = table.Column<string>(maxLength: 255, nullable: true),
                    OptInConsent = table.Column<string>(maxLength: 255, nullable: true),
                    Phone = table.Column<string>(maxLength: 255, nullable: true),
                    PreferredContact = table.Column<string>(maxLength: 255, nullable: true),
                    Prefix = table.Column<string>(maxLength: 255, nullable: true),
                    ProgramInterest = table.Column<string>(maxLength: 255, nullable: true),
                    State = table.Column<string>(maxLength: 255, nullable: true),
                    VendorName = table.Column<string>(maxLength: 255, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpenHouse",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    DateSynced = table.Column<DateTime>(nullable: false),
                    IsSynced = table.Column<bool>(nullable: true),
                    ad_type = table.Column<string>(maxLength: 255, nullable: true),
                    apartment_number = table.Column<string>(maxLength: 255, nullable: true),
                    city = table.Column<string>(maxLength: 255, nullable: true),
                    confirm_email = table.Column<string>(maxLength: 255, nullable: true),
                    country = table.Column<string>(maxLength: 255, nullable: true),
                    email_address = table.Column<string>(maxLength: 255, nullable: true),
                    employer_name = table.Column<string>(maxLength: 255, nullable: true),
                    employer_name_other = table.Column<string>(maxLength: 255, nullable: true),
                    first_name = table.Column<string>(maxLength: 255, nullable: true),
                    how_did_you_hear = table.Column<string>(maxLength: 255, nullable: true),
                    last_name = table.Column<string>(maxLength: 255, nullable: true),
                    maiden_name = table.Column<string>(maxLength: 255, nullable: true),
                    middle_name = table.Column<string>(maxLength: 255, nullable: true),
                    military_branch = table.Column<string>(maxLength: 255, nullable: true),
                    name_of_event = table.Column<string>(maxLength: 255, nullable: true),
                    name_of_state = table.Column<string>(maxLength: 255, nullable: true),
                    open_house_session = table.Column<string>(maxLength: 255, nullable: true),
                    other_country = table.Column<string>(maxLength: 255, nullable: true),
                    primary_phone = table.Column<string>(maxLength: 255, nullable: true),
                    primary_phone_type = table.Column<string>(maxLength: 255, nullable: true),
                    program_concentration = table.Column<string>(maxLength: 255, nullable: true),
                    program_degree = table.Column<string>(maxLength: 255, nullable: true),
                    programs_interested = table.Column<string>(maxLength: 255, nullable: true),
                    referral_source = table.Column<string>(maxLength: 255, nullable: true),
                    referred_by = table.Column<string>(maxLength: 255, nullable: true),
                    referred_by_whom = table.Column<string>(maxLength: 255, nullable: true),
                    secondary_phone = table.Column<string>(maxLength: 255, nullable: true),
                    secondary_phone_type = table.Column<string>(maxLength: 255, nullable: true),
                    street_address = table.Column<string>(maxLength: 255, nullable: true),
                    stte = table.Column<string>(maxLength: 255, nullable: true),
                    suffix = table.Column<string>(maxLength: 255, nullable: true),
                    zip_code = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenHouse", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionForUs",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    DateSynced = table.Column<DateTime>(nullable: false),
                    IsSynced = table.Column<bool>(nullable: true),
                    dropdown_list_field_controller = table.Column<string>(maxLength: 255, nullable: true),
                    pragraph_text_field_controller = table.Column<string>(maxLength: 255, nullable: true),
                    text_field_controller = table.Column<string>(maxLength: 255, nullable: true),
                    text_field_controller_0 = table.Column<string>(maxLength: 255, nullable: true),
                    text_field_controller_1 = table.Column<string>(maxLength: 255, nullable: true),
                    text_field_controller_2 = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionForUs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ReferAFriend",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    DateSynced = table.Column<DateTime>(nullable: false),
                    IsSynced = table.Column<bool>(nullable: true),
                    pragraph_text_field_controller = table.Column<string>(maxLength: 255, nullable: true),
                    text_field_controller = table.Column<string>(maxLength: 255, nullable: true),
                    text_field_controller_0 = table.Column<string>(maxLength: 255, nullable: true),
                    text_field_controller_1 = table.Column<string>(maxLength: 255, nullable: true),
                    text_field_controller_2 = table.Column<string>(maxLength: 255, nullable: true),
                    text_field_controller_3 = table.Column<string>(maxLength: 255, nullable: true),
                    text_field_controller_4 = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferAFriend", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.DropTable(
                name: "EmailUs");

            migrationBuilder.DropTable(
                name: "Inquiry");

            migrationBuilder.DropTable(
                name: "Leads");

            migrationBuilder.DropTable(
                name: "OpenHouse");

            migrationBuilder.DropTable(
                name: "QuestionForUs");

            migrationBuilder.DropTable(
                name: "ReferAFriend");
        }
    }
}
