using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using LeadsManager.Data;

namespace LeadsManager.Migrations
{
    [DbContext(typeof(LeadsContext))]
    partial class LeadsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LeadsManager.Models.Application", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateSynced");

                    b.Property<bool?>("IsSynced");

                    b.Property<string>("ad_type")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("apartment_name")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("citizenship_country")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("city")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("college_other")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("confirm_email")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("country")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("current_employer")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("currently_employed")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("date_of_birth")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("diploma_or_ged")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("email_address")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("employer_name")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("employer_other")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("ethnicity")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("first_name")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("gender_id")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("h_s_graduation_year")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("h_s_state")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("high_school_name")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("highest_level_education")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("how_did_you_hear")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("how_soon_start")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("last_name")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("maiden_name")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("middle_name")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("military_branch")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("name_of_event")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("name_of_state")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("other_country")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("previously_attended")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("primary_phone")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("primary_phone_type")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("program_concentration")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("program_degree")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("programs_interested")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("race")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("referral_source")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("referred_by")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("referred_by_whom")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("school_name")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("secondary_phone")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("seconday_phone_type")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("social_security")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("street_address")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("stte")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("suffix")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("zip_code")
                        .HasAnnotation("MaxLength", 255);

                    b.HasKey("id");

                    b.ToTable("Application");
                });

            modelBuilder.Entity("LeadsManager.Models.EmailUs", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateSynced");

                    b.Property<bool?>("IsSynced");

                    b.Property<string>("dropdown_list_field_controller")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("pragraph_text_field_controller")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("text_field_controller")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("text_field_controller_0")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("text_field_controller_1")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("text_field_controller_2")
                        .HasAnnotation("MaxLength", 255);

                    b.HasKey("id");

                    b.ToTable("EmailUs");
                });

            modelBuilder.Entity("LeadsManager.Models.Inquiry", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateSynced");

                    b.Property<bool?>("IsSynced");

                    b.Property<string>("ad_type")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("apartment_number")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("city")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("confirm_email")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("country")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("diploma_or_ged")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("email_address")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("evaluation")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("first_name")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("how_did_you_hear")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("how_soon_start")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("last_name")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("maiden_name")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("middle_name")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("military")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("name_of_event")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("other_country")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("previously_attended")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("primary_phone")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("primary_phone_type")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("program_concentration")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("program_degree")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("programs_interested")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("referral_employer")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("referral_other_employer")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("referral_other_school")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("referral_school")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("referral_source")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("referred_by")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("referred_by_whom")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("secondary_phone")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("secondary_phone_type")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("state_name")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("street_address")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("stte")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("suffix")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("zip_code")
                        .HasAnnotation("MaxLength", 255);

                    b.HasKey("id");

                    b.ToTable("Inquiry");
                });

            modelBuilder.Entity("LeadsManager.Models.LandingPage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("Age")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("City")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("Country")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateSynced");

                    b.Property<string>("DesiredStart")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("FirstName")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("FormName")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("HSGradYear")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("HighestEduCompleted")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<bool?>("IsSynced");

                    b.Property<string>("Key")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("LastName")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("MilitaryAffiliation")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("OptInConsent")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("Phone")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("PreferredContact")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("Prefix")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("ProgramInterest")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("State")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("VendorName")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("ZipCode")
                        .HasAnnotation("MaxLength", 255);

                    b.HasKey("Id");

                    b.ToTable("Leads");
                });

            modelBuilder.Entity("LeadsManager.Models.OpenHouse", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateSynced");

                    b.Property<bool?>("IsSynced");

                    b.Property<string>("ad_type")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("apartment_number")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("city")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("confirm_email")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("country")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("email_address")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("employer_name")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("employer_name_other")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("first_name")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("how_did_you_hear")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("last_name")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("maiden_name")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("middle_name")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("military_branch")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("name_of_event")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("name_of_state")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("open_house_session")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("other_country")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("primary_phone")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("primary_phone_type")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("program_concentration")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("program_degree")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("programs_interested")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("referral_source")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("referred_by")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("referred_by_whom")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("secondary_phone")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("secondary_phone_type")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("street_address")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("stte")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("suffix")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("zip_code")
                        .HasAnnotation("MaxLength", 255);

                    b.HasKey("id");

                    b.ToTable("OpenHouse");
                });

            modelBuilder.Entity("LeadsManager.Models.QuestionForUs", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateSynced");

                    b.Property<bool?>("IsSynced");

                    b.Property<string>("dropdown_list_field_controller")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("pragraph_text_field_controller")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("text_field_controller")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("text_field_controller_0")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("text_field_controller_1")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("text_field_controller_2")
                        .HasAnnotation("MaxLength", 255);

                    b.HasKey("id");

                    b.ToTable("QuestionForUs");
                });

            modelBuilder.Entity("LeadsManager.Models.ReferAFriend", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateSynced");

                    b.Property<bool?>("IsSynced");

                    b.Property<string>("pragraph_text_field_controller")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("text_field_controller")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("text_field_controller_0")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("text_field_controller_1")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("text_field_controller_2")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("text_field_controller_3")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("text_field_controller_4")
                        .HasAnnotation("MaxLength", 255);

                    b.HasKey("id");

                    b.ToTable("ReferAFriend");
                });
        }
    }
}
