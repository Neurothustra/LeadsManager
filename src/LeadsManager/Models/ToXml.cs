using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace LeadsManager.Models
{
    public class ToXml
    {
        StringBuilder sb = new StringBuilder();

        //Default all properties to an empty string so that no bad data breaks XML generation
        private string FullName { get; set; } = "";
        private string FirstName { get; set; } = "";
        private string LastName { get; set; } = "";
        private string MiddleName { get; set; } = "";
        private string MaidenName { get; set; } = "";
        private string Suffix { get; set; } = "";
        private string Address { get; set; } = "";
        private string AptNumber { get; set; } = "";
        private string City { get; set; } = "";
        private string State { get; set; } = "";
        private string Country { get; set; } = "";
        private string Zip { get; set; } = "";
        private string Phone { get; set; } = "";
        private string Phone1Type { get; set; } = "";
        private string Phone2 { get; set; } = "";
        private string Phone2Type { get; set; } = "";
        private string Email { get; set; } = "";
        private string Program { get; set; } = "";
        private string PreferredContact { get; set; } = "";
        private string MilitaryBranch { get; set; } = "";
        private string Request { get; set; } = "";
        private string DegreeType { get; set; } = "";
        private string Concentration { get; set; } = "";
        private string OpenHouseSession { get; set; } = "";
        private string AdSource { get; set; } = "";
        private string AdDescription { get; set; } = "";
        private string AdNote { get; set; } = "";
        private string HowSoonToStart { get; set; } = "";
        private string PreviouslyAttendPeirce { get; set; } = "";
        private string HighSchoolGED { get; set; } = "";
        private string GenderIdentity { get; set; } = "";
        private string DateOfBirth { get; set; } = "";
        private string CountryCitizenship { get; set; } = "";
        private string Ethnicity { get; set; } = "";
        private string Race { get; set; } = "";
        private string SSN { get; set; } = "";
        private string CurrentlyEmployed { get; set; } = "";
        private string HowMayWeHelp { get; set; } = "";
        private string Comments { get; set; } = "";
        private string FriendFirstName { get; set; } = "";
        private string FriendLastName { get; set; } = "";
        private string FriendEmail { get; set; } = "";
        private string Stage { get; set; } = "";
        private DateTime CurrentDate { get; set; }
        private string FormName { get; set; }

        public XElement BuildFormXml(LandingPage landingPage)
        {

            FullName = $"{landingPage.FirstName} {landingPage.LastName}";
            FirstName = landingPage.FirstName ?? "";
            LastName = landingPage.LastName ?? "";
            Address = landingPage.Address ?? "";
            City = landingPage.City ?? "";
            State = landingPage.State ?? "";
            Country = landingPage.Country ?? "";
            Zip = landingPage.ZipCode ?? "";
            Phone = landingPage.Phone ?? "";
            Email = landingPage.Email ?? "";
            Program = landingPage.ProgramInterest ?? "";
            PreferredContact = landingPage.PreferredContact ?? "";
            Stage = "Pre-Inquiry";

            if (landingPage.MilitaryAffiliation != "-Select-")
            {
                MilitaryBranch = landingPage.MilitaryAffiliation ?? "";
            }
            else
            {
                MilitaryBranch = "";
            }

            Request = sb.AppendFormat($"name={FullName} Email={Email} Street1={Address} City={City} State={State} Zip={Zip} Phone1={Phone}").ToString();

            XElement msg = BuildXml(FullName, FirstName, LastName, MiddleName, MaidenName, Suffix, Address, AptNumber, City, State, Country, Zip, Phone, Phone1Type, Phone2, Phone2Type, Email, Program, PreferredContact, MilitaryBranch, Request, DegreeType, Concentration, OpenHouseSession, AdSource, AdDescription, AdNote, HowSoonToStart, PreviouslyAttendPeirce, HighSchoolGED, GenderIdentity, DateOfBirth, CountryCitizenship, Ethnicity, Race, SSN, CurrentlyEmployed, CurrentDate.ToString(), Stage, "Leads Generator");

            return msg;
        }

        public XElement BuildFormXml(QuestionForUs question)
        {
            CurrentDate = DateTime.Now;

            FirstName = question.text_field_controller ?? "";
            LastName = question.text_field_controller_0 ?? "";
            Email = question.text_field_controller_1 ?? "";
            Phone = question.text_field_controller_2 ?? "";
            Comments = question.pragraph_text_field_controller ?? "";
            HowMayWeHelp = question.dropdown_list_field_controller ?? "";
            Stage = "Pre-Inquiry";

            sb.AppendLine(FirstName);
            sb.AppendLine(LastName);
            sb.AppendLine(Email);
            sb.AppendLine(Phone);
            sb.AppendLine(Comments);
            sb.AppendLine(HowMayWeHelp);
            Request = sb.ToString();

            XElement msg = BuildXml(FullName, FirstName, LastName, MiddleName, MaidenName, Suffix, Address, AptNumber, City, State, Country, Zip, Phone, Phone1Type, Phone2, Phone2Type, Email, Program, PreferredContact, MilitaryBranch, Request, DegreeType, Concentration, OpenHouseSession, AdSource, AdDescription, AdNote, HowSoonToStart, PreviouslyAttendPeirce, HighSchoolGED, GenderIdentity, DateOfBirth, CountryCitizenship, Ethnicity, Race, SSN, CurrentlyEmployed, CurrentDate.ToString(), Stage, "Question For Us");

            return msg;
        }

        public XElement BuildFormXml(EmailUs emailUs)
        {
            CurrentDate = DateTime.Now;

            FirstName = emailUs.text_field_controller ?? "";
            LastName = emailUs.text_field_controller_0 ?? "";
            Email = emailUs.text_field_controller_1 ?? "";
            Phone = emailUs.text_field_controller_2 ?? "";
            Comments = emailUs.pragraph_text_field_controller ?? "";
            HowMayWeHelp = emailUs.dropdown_list_field_controller ?? "";
            Stage = "Pre-Inquiry";

            sb.AppendLine(FirstName);
            sb.AppendLine(LastName);
            sb.AppendLine(Email);
            sb.AppendLine(Phone);
            sb.AppendLine(Comments);
            sb.AppendLine(HowMayWeHelp);
            Request = sb.ToString();

            XElement msg = BuildXml(FullName, FirstName, LastName, MiddleName, MaidenName, Suffix, Address, AptNumber, City, State, Country, Zip, Phone, Phone1Type, Phone2, Phone2Type, Email, Program, PreferredContact, MilitaryBranch, Request, DegreeType, Concentration, OpenHouseSession, AdSource, AdDescription, AdNote, HowSoonToStart, PreviouslyAttendPeirce, HighSchoolGED, GenderIdentity, DateOfBirth, CountryCitizenship, Ethnicity, Race, SSN, CurrentlyEmployed, CurrentDate.ToString(), Stage, "Email Us");

            return msg;
        }

        public XElement BuildFormXml(ReferAFriend referFriend)
        {
            CurrentDate = DateTime.Now;

            FirstName = referFriend.text_field_controller ?? "";
            LastName = referFriend.text_field_controller_0 ?? "";
            Email = referFriend.text_field_controller_1 ?? "";
            FriendFirstName = referFriend.text_field_controller_2 ?? "";
            FriendLastName = referFriend.text_field_controller_3 ?? "";
            FriendEmail = referFriend.text_field_controller_4 ?? "";
            Comments = referFriend.pragraph_text_field_controller ?? "";
            Stage = "Pre-Inquiry";

            sb.AppendLine(FirstName);
            sb.AppendLine(LastName);
            sb.AppendLine(Email);
            sb.AppendLine(FriendFirstName);
            sb.AppendLine(FriendLastName);
            sb.AppendLine(FriendEmail);
            sb.AppendLine(Comments);
            Request = sb.ToString();

            XElement msg = BuildXml(FullName, FirstName, LastName, MiddleName, MaidenName, Suffix, Address, AptNumber, City, State, Country, Zip, Phone, Phone1Type, Phone2, Phone2Type, Email, Program, PreferredContact, MilitaryBranch, Request, DegreeType, Concentration, OpenHouseSession, AdSource, AdDescription, AdNote, HowSoonToStart, PreviouslyAttendPeirce, HighSchoolGED, GenderIdentity, DateOfBirth, CountryCitizenship, Ethnicity, Race, SSN, CurrentlyEmployed, CurrentDate.ToString(), Stage, "Email Us");

            return msg;
        }

        public XElement BuildFormXml(OpenHouse openHouse)
        {
            CurrentDate = DateTime.Now;

            FirstName = openHouse.first_name ?? "";
            MiddleName = openHouse.middle_name ?? "";
            LastName = openHouse.last_name ?? "";

            if (openHouse.maiden_name != "")
            {
                MaidenName = $"{openHouse.maiden_name}" ?? "";
            }

            if (openHouse.suffix != "- Select -")
            {
                Suffix = openHouse.suffix;
            }

            FullName = $"{FirstName} {LastName}";

            if (openHouse.street_address != "")
            {
                if (openHouse.apartment_number != "")
                {
                    Address = $"{openHouse.street_address} Apt {openHouse.apartment_number}" ?? "";
                }
                else
                {
                    Address = openHouse.street_address ?? "";
                }
            }

            City = openHouse.city ?? "";

            OpenHouseSession = $"Open House: {openHouse.open_house_session}" ?? "No Open House Session Selected";
            Zip = openHouse.zip_code ?? "";
            Phone = openHouse.primary_phone ?? "";

            if (openHouse.primary_phone_type != "- Select -")
            {
                Phone1Type = openHouse.primary_phone_type ?? "";
            }
            else
            {
                Phone1Type = "";
            }

            Phone2 = openHouse.secondary_phone ?? "";

            if (openHouse.secondary_phone_type != "- Select -")
            {
                Phone2Type = openHouse.secondary_phone_type ?? "";
            }
            else
            {
                Phone2Type = "";
            }

            Email = openHouse.email_address ?? "";

            if (openHouse.military_branch != "- Select -")
            {
                MilitaryBranch = openHouse.military_branch ?? "";
            }
            else
            {
                MilitaryBranch = "";
            }

            //"stte" is "state" but misspelled in the DB
            if (openHouse.stte != null)
            {
                if (openHouse.stte != "--Other--")
                {
                    State = openHouse.stte;
                }
                else
                {
                    State = openHouse.name_of_state;
                }
            }

            if (openHouse.country != "--Other--")
            {
                Country = openHouse.country ?? "";
            }
            else
            {
                Country = openHouse.other_country ?? "";
            }

            Program = openHouse.programs_interested ?? "";
            Concentration = openHouse.program_concentration ?? "";
            DegreeType = openHouse.program_degree ?? "";

            switch (openHouse.referred_by)
            {
                case "Yes":
                    switch (openHouse.referred_by_whom)
                    {
                        case "- Select -":
                            AdSource = "";
                            break;
                        case "Other":
                            AdSource = "Referred by";
                            AdNote = openHouse.referral_source;
                            break;
                        default:
                            AdSource = "Referred by";
                            AdNote = openHouse.referred_by_whom;
                            break;
                    }
                    break;
                case "No":
                    switch (openHouse.how_did_you_hear)
                    {
                        case "- Select -":
                            AdSource = "";
                            break;
                        case "Advertisement":
                            AdSource = openHouse.how_did_you_hear;
                            AdNote = openHouse.ad_type;
                            break;
                        case "Internet Search Engine":
                            AdSource = openHouse.how_did_you_hear;
                            break;
                        case "Event":
                            AdSource = openHouse.how_did_you_hear;
                            AdNote = openHouse.name_of_event;
                            break;
                        case "Employer":
                            AdSource = openHouse.how_did_you_hear;
                            if (openHouse.employer_name != "- Select -")
                            {
                                if (openHouse.employer_name == "Other")
                                {
                                    AdNote = openHouse.employer_name_other;
                                }
                                else
                                {
                                    AdNote = openHouse.employer_name;
                                }
                            }
                            break;
                        case "Military":
                            AdSource = openHouse.how_did_you_hear;
                            if (openHouse.military_branch != "- Select -")
                            {
                                AdNote = openHouse.military_branch;
                            }
                            break;
                        default:
                            break;
                    }
                    break;
            }

            Stage = "Inquiry";

            sb.AppendLine($"AdSource = {AdSource} ");
            if (AdNote != "") { sb.AppendLine($"AdNote = {AdNote}"); }
            sb.AppendLine($"Email = {Email} ");
            sb.AppendLine($"NameFirst = {FirstName} ");
            sb.AppendLine($"NameLast = {LastName} ");
            sb.AppendLine($"Phone = {Phone} ");
            sb.AppendLine($"Street = {Address} ");
            sb.AppendLine($"City = {City} ");
            sb.AppendLine($"State = {State} ");
            sb.AppendLine($"PostalCode = {Zip} ");
            sb.AppendLine($"Country = {Country} ");
            sb.AppendLine($"DegreeType = {DegreeType} ");
            sb.AppendLine($"Program = {Program} ");
            sb.AppendLine($"Concentration = {Concentration}");
            Request = sb.ToString();

            XElement msg = BuildXml(FullName, FirstName, LastName, MiddleName, MaidenName, Suffix, Address, AptNumber, City, State, Country, Zip, Phone, Phone1Type, Phone2, Phone2Type, Email, Program, PreferredContact, MilitaryBranch, Request, DegreeType, Concentration, OpenHouseSession, AdSource, AdDescription, AdNote, HowSoonToStart, PreviouslyAttendPeirce, HighSchoolGED, GenderIdentity, DateOfBirth, CountryCitizenship, Ethnicity, Race, SSN, CurrentlyEmployed, CurrentDate.ToString(), Stage, "Undergrad Open House");

            return msg;
        }

        public XElement BuildFormXml(Inquiry inquiry)
        {
            CurrentDate = DateTime.Now;
            FirstName = inquiry.first_name ?? "";

            LastName = inquiry.last_name ?? "";

            MiddleName = inquiry.middle_name ?? "";

            if (inquiry.maiden_name != "")
            {
                MaidenName = $"{inquiry.maiden_name}" ?? "";
            }

            if (inquiry.suffix != "- Select -")
            {
                Suffix = Suffix = inquiry.suffix ?? "";
            }

            FullName = $"{FirstName} {LastName}";

            if (inquiry.street_address != "")
            {
                if (inquiry.apartment_number != "")
                {
                    Address = $"{inquiry.street_address} Apt: {inquiry.apartment_number}" ?? "";
                }
                else
                {
                    Address = inquiry.street_address ?? "";
                }
            }

            City = inquiry.city ?? "";
            Zip = inquiry.zip_code ?? "";
            Phone = inquiry.primary_phone ?? "";
            Phone1Type = inquiry.primary_phone_type ?? "";

            if (inquiry.secondary_phone_type != "- Select -")
            {
                Phone1Type = inquiry.primary_phone_type ?? "";
            }
            else
            {
                Phone1Type = "";
            }

            Phone2 = inquiry.secondary_phone ?? "";

            if (inquiry.secondary_phone_type != "- Select -")
            {
                Phone2Type = inquiry.secondary_phone_type ?? "";
            }
            else
            {
                Phone2Type = "";
            }

            Email = inquiry.email_address ?? "";
            Program = inquiry.programs_interested ?? "";

            if (inquiry.military != "- Select -")
            {
                MilitaryBranch = inquiry.military ?? "";
            }
            else
            {
                MilitaryBranch = "";
            }

            DegreeType = inquiry.programs_interested ?? "";

            //"stte" is "state" but misspelled in the DB, renaming it will cause issues
            if (inquiry.stte == "--Other--")
            {
                State = inquiry.state_name;
            }
            else
            {
                State = inquiry.stte ?? "";
            }

            if (inquiry.country == "--Other--")
            {
                Country = inquiry.other_country;
            }
            else
            {
                Country = inquiry.country ?? "";
            }

            if (inquiry.apartment_number != "")
            {
                Address = $"{inquiry.street_address} Apt {inquiry.apartment_number}" ?? "";
            }
            else
            {
                Address = inquiry.street_address ?? "";
            }

            Program = inquiry.programs_interested ?? "";
            DegreeType = inquiry.program_degree ?? "";
            Concentration = inquiry.program_concentration ?? "";

            switch (inquiry.referred_by)
            {
                case "Yes":
                    switch (inquiry.referred_by_whom)
                    {
                        case "- Select -":
                            AdSource = "";
                            break;
                        case "Other":
                            AdSource = "Referred by";
                            AdNote = inquiry.referral_source;
                            break;
                        default:
                            AdSource = "Referred by";
                            AdNote = inquiry.referred_by_whom;
                            break;
                    }
                    break;
                case "No":
                    switch (inquiry.how_did_you_hear)
                    {
                        case "- Select -":
                            AdSource = "";
                            break;
                        case "Advertisement":
                            AdSource = inquiry.how_did_you_hear;
                            AdNote = inquiry.ad_type;
                            break;
                        case "Internet Search Engine":
                            AdSource = inquiry.how_did_you_hear;
                            break;
                        case "Event":
                            AdSource = inquiry.how_did_you_hear;
                            AdNote = inquiry.name_of_event;
                            break;
                        case "Employer":
                            AdSource = inquiry.how_did_you_hear;
                            if (inquiry.referral_employer != "- Select -")
                            {
                                if (inquiry.referral_employer == "Other")
                                {
                                    AdNote = inquiry.referral_other_employer;
                                }
                                else
                                {
                                    AdNote = inquiry.referral_employer;
                                }
                            }
                            break;
                        case "Military":
                            AdSource = inquiry.how_did_you_hear;
                            if (inquiry.military != "- Select -")
                            {
                                AdNote = inquiry.military;
                            }
                            break;
                        default:
                            break;
                    }
                    break;
            }

            Stage = "Inquiry";

            sb.AppendLine($"AdSource = {AdSource} ");
            if (AdNote != "") { sb.AppendLine($"AdNote = {AdNote}"); }
            sb.AppendLine($"Email = {Email} ");
            sb.AppendLine($"NameFirst = {FirstName} ");
            sb.AppendLine($"NameLast = {LastName} ");
            sb.AppendLine($"Phone = {Phone} ");
            sb.AppendLine($"Street Address = {Address} ");
            sb.AppendLine($"City = {City} ");
            sb.AppendLine($"State = {State} ");
            sb.AppendLine($"PostalCode = {Zip} ");
            sb.AppendLine($"Country = {Country} ");
            sb.AppendLine($"Country = {Country} ");
            sb.AppendLine($"DegreeType = {DegreeType} ");
            sb.AppendLine($"Program = {Program}");
            sb.AppendLine($"Concentration = {Concentration}");
            Request = sb.ToString();

            XElement msg = BuildXml(FullName, FirstName, LastName, MiddleName, MaidenName, Suffix, Address, AptNumber, City, State, Country, Zip, Phone, Phone1Type, Phone2, Phone2Type, Email, Program, PreferredContact, MilitaryBranch, Request, DegreeType, Concentration, OpenHouseSession, AdSource, AdDescription, AdNote, HowSoonToStart, PreviouslyAttendPeirce, HighSchoolGED, GenderIdentity, DateOfBirth, CountryCitizenship, Ethnicity, Race, SSN, CurrentlyEmployed, CurrentDate.ToString(), Stage, "Undergrad Inquiry");

            return msg;
        }

        public XElement BuildFormXml(Application application)
        {
            CurrentDate = DateTime.Now;
            FirstName = application.first_name ?? "";
            LastName = application.last_name ?? "";

            if (application.middle_name != "- Select -")
            {
                MiddleName = application.middle_name ?? "";
            }

            if (application.maiden_name != "")
            {
                MaidenName = $"{application.maiden_name}" ?? "";
            }

            if (application.suffix != "- Select -")
            {
                Suffix = application.suffix ?? "";
            }

            FullName = $"{FirstName} {LastName}";

            if (application.street_address != null)
            {
                if (application.apartment_name != null)
                {
                    Address = $"{application.street_address} Apt: {application.apartment_name}";
                }
            }

            if (application.city != "- Select -")
            {
                City = application.city ?? "";
            }

            Zip = application.zip_code ?? "";
            Phone = application.primary_phone ?? "";

            if (application.primary_phone_type != "- Select -")
            {
                Phone1Type = application.primary_phone_type ?? "";
            }
            else
            {
                Phone1Type = "";
            }

            Phone2 = application.secondary_phone ?? "";

            if (application.seconday_phone_type != "- Select -")
            {
                Phone2Type = application.seconday_phone_type ?? "";
            }
            else
            {
                Phone2Type = "";
            }

            Email = application.email_address ?? "";

            if (application.military_branch != "- Select -")
            {
                MilitaryBranch = application.military_branch ?? "";
            }
            else
            {
                MilitaryBranch = "";
            }

            Program = application.programs_interested ?? "";
            Concentration = application.program_concentration ?? "";
            DegreeType = application.program_degree ?? "";
            HowSoonToStart = application.how_soon_start ?? "";
            PreviouslyAttendPeirce = application.previously_attended ?? "";
            GenderIdentity = application.gender_id ?? "";
            DateOfBirth = application.date_of_birth ?? "";

            if (application.citizenship_country == "--Other--")
            {
                CountryCitizenship = application.other_country ?? "";
            }
            else
            {
                CountryCitizenship = application.citizenship_country ?? "";
            }

            Race = application.race ?? "";
            SSN = application.social_security ?? "";

            //"stte" is "state" but misspelled in the DB, renaming it will cause issues
            if (application.stte == "--Other--")
            {
                State = application.name_of_state ?? "";
            }

            if (application.country == "--Other--")
            {
                Country = application.other_country ?? "";
            }
            else
            {
                Country = application.country ?? "";
            }

            Program = application.programs_interested ?? "";
            DegreeType = application.program_degree ?? "";
            Concentration = application.program_concentration ?? "";

            switch (application.referred_by)
            {
                case "Yes":
                    switch (application.referred_by_whom)
                    {
                        case "- Select -":
                            AdSource = "";
                            break;
                        case "Other":
                            AdSource = "Referred by";
                            AdNote = application.referral_source;
                            break;
                        default:
                            AdSource = "Referred by";
                            AdNote = application.referred_by_whom;
                            break;
                    }
                    break;
                case "No":
                    switch (application.how_did_you_hear)
                    {
                        case "- Select -":
                            AdSource = "";
                            break;
                        case "Advertisement":
                            AdSource = application.how_did_you_hear;
                            AdNote = application.ad_type;
                            break;
                        case "Internet Search Engine":
                            AdSource = application.how_did_you_hear;
                            break;
                        case "Event":
                            AdSource = application.how_did_you_hear;
                            AdNote = application.name_of_event;
                            break;
                        case "Employer":
                            AdSource = application.how_did_you_hear;
                            if (application.employer_name != "- Select -")
                            {
                                if (application.employer_name == "Other")
                                {
                                    AdNote = application.employer_other;
                                }
                                else
                                {
                                    AdNote = application.employer_name;
                                }
                            }
                            break;
                        case "Military":
                            AdSource = application.how_did_you_hear;
                            if (application.military_branch != "- Select -")
                            {
                                AdNote = application.military_branch;
                            }
                            break;
                        default:
                            break;
                    }
                    break;
            }

            switch (application.diploma_or_ged)
            {
                case "High School Diploma":
                    HighSchoolGED = $"{application.diploma_or_ged}: {application.high_school_name}, Graduation Year = {application.h_s_graduation_year}, HS State {application.h_s_state}";
                    break;
                case "GED":
                    HighSchoolGED = application.diploma_or_ged;
                    break;
            }

            switch (application.currently_employed)
            {
                case "Yes":
                    CurrentlyEmployed = application.current_employer;
                    break;
                case "No":
                    CurrentlyEmployed = application.currently_employed;
                    break;
            }

            if (application.apartment_name != "")
            {
                Address = $"{application.street_address} Apt {application.apartment_name}" ?? "";
            }
            else
            {
                Address = application.street_address ?? "";
            }

            if (Ethnicity != null)
            {
                Ethnicity = application.ethnicity ?? "";
            }

            Stage = "Application";

            sb.AppendLine($"Date = {CurrentDate} ");
            sb.AppendLine($"AdSource = {AdSource} ");
            if (AdNote != "") { sb.AppendLine($"AdNote = {AdNote}"); }
            sb.AppendLine($"Email = {Email} ");
            sb.AppendLine($"NameFirst = {FirstName} ");
            sb.AppendLine($"NameLast = {LastName} ");
            sb.AppendLine($"Phone = {Phone} ");
            sb.AppendLine($"Street = {Address} ");
            sb.AppendLine($"City = {City} ");
            sb.AppendLine($"State = {State} ");
            sb.AppendLine($"PostalCode = {Zip} ");
            sb.AppendLine($"Country = {Country} ");
            sb.AppendLine($"DegreeType = {DegreeType} ");
            sb.AppendLine($"Program = {Program}");
            sb.AppendLine($"Concentration = {Concentration}");
            sb.AppendLine($"HowSoonToStart = {HowSoonToStart} ");
            sb.AppendLine($"PreviouslyAttendPeirce = {PreviouslyAttendPeirce} ");
            sb.AppendLine($"High School or GED = {HighSchoolGED} ");
            sb.AppendLine($"GenderIdentity = {GenderIdentity} ");
            sb.AppendLine($"DateOfBirth = {DateOfBirth} ");
            sb.AppendLine($"CountryOfCitizenship = {CountryCitizenship} ");
            sb.AppendLine($"Ethnicity = {Ethnicity} ");
            sb.AppendLine($"Race = {Race} ");
            //sb.AppendLine($"SSN = {SSN} ");
            sb.AppendLine($"Currently Employed = {CurrentlyEmployed} ");
            Request = sb.ToString();

            XElement msg = BuildXml(FullName, FirstName, LastName, MiddleName, MaidenName, Suffix, Address, AptNumber, City, State, Country, Zip, Phone, Phone1Type, Phone2, Phone2Type, Email, Program, PreferredContact, MilitaryBranch, Request, DegreeType, Concentration, OpenHouseSession, AdSource, AdDescription, AdNote, HowSoonToStart, PreviouslyAttendPeirce, HighSchoolGED, GenderIdentity, DateOfBirth, CountryCitizenship, Ethnicity, Race, SSN, CurrentlyEmployed, CurrentDate.ToString(), Stage, "Undergrad Application");

            return msg;
        }

        public XElement BuildXml(string fullName,
            string firstName,
            string lastName,
            string middleName,
            string maidenName,
            string suffix,
            string address,
            string aptNumber,
            string city,
            string state,
            string country,
            string zip,
            string phone,
            string phoneType,
            string phone2,
            string phone2Type,
            string email,
            string program,
            string preferredContact,
            string militaryBranch,
            string request,
            string degreeType,
            string concentration,
            string openHouseSession,
            string adSource,
            string adDescription,
            string adNote,
            string howSoonStart,
            string previouslyAttendPeirce,
            string highSchoolGed,
            string genderIdentity,
            string dateOfBirth,
            string countryCitizenship,
            string ethnicity,
            string race,
            string ssn,
            string currentlyEmployed,
            string currentDate,
            string stage,
            string formType)
        {
            XElement x = new XElement("WebForm",
                                new XElement("Object",
                                    new XElement("ObjectID", "-1"),
                                    new XElement("LANG", "ENGLISH"),
                                    new XElement("DLID", "1033"),
                                    new XElement("Object.Name", "Contact"),
                                    new XElement("PropList",
                                        new XElement("Tab",
                                            new XElement("Tab.Name", "Properties"),
                                            new XElement("Group",
                                                new XElement("Group.Name"),
                                                new XElement("Property", new XElement("Property.Name", "Name"), new XElement("Value", new XCData(fullName))),
                                                new XElement("Property", new XElement("Property.Name", "E-Mail"), new XElement("Value", new XCData(email))),
                                                new XElement("Property", new XElement("Property.Name", "Secondary Email"), new XElement("Value", new XCData("")))
                                            ),
                                            new XElement("Group",
                                                new XElement("Group.Name", "Full Name"),
                                                new XElement("Property", new XElement("Property.Name", "Salutations"), new XElement("Value", new XCData(""))),
                                                new XElement("Property", new XElement("Property.Name", "First Name"), new XElement("Value", new XCData(firstName))),
                                                new XElement("Property", new XElement("Property.Name", "Middle Name"), new XElement("Value", new XCData(middleName))),
                                                new XElement("Property", new XElement("Property.Name", "Maiden Name"), new XElement("Value", new XCData(maidenName))),
                                                new XElement("Property", new XElement("Property.Name", "Last Name"), new XElement("Value", new XCData(lastName))),
                                                new XElement("Property", new XElement("Property.Name", "Suffix"), new XElement("Value", new XCData(suffix)))
                                            ),
                                            new XElement("Group",
                                                new XElement("Group.Name", "Address"),
                                                new XElement("Property", new XElement("Property.Name", "Street 1"), new XElement("Value", new XCData(address))),
                                                new XElement("Property", new XElement("Property.Name", "Street 2"), new XElement("Value", new XCData(""))),
                                                new XElement("Property", new XElement("Property.Name", "City"), new XElement("Value", new XCData(city))),
                                                new XElement("Property", new XElement("Property.Name", "State"), new XElement("Value", new XCData(state))),
                                                new XElement("Property", new XElement("Property.Name", "Zip"), new XElement("Value", new XCData(zip))),
                                                new XElement("Property", new XElement("Property.Name", "Country"), new XElement("Value", new XCData(country))),
                                                new XElement("Property", new XElement("Property.Name", "Phone1"), new XElement("Value", new XCData(phone))),
                                                new XElement("Property", new XElement("Property.Name", "Phone1 Type"), new XElement("Value", new XCData(phoneType))),
                                                new XElement("Property", new XElement("Property.Name", "Phone2"), new XElement("Value", new XCData(phone2))),
                                                new XElement("Property", new XElement("Property.Name", "Phone2 Type"), new XElement("Value", new XCData(phone2Type)))
                                            )),
                                        new XElement("Tab",
                                            new XElement("Tab.Name", "Biographical Info"),
                                            new XElement("Group",
                                                new XElement("Group.Name", "General"),
                                                new XElement("Property", new XElement("Property.Name", "Preferred Contact Method"), new XElement("Value", new XCData(preferredContact))),
                                                new XElement("Property", new XElement("Property.Name", "Gender"), new XElement("Value", new XCData(genderIdentity))),
                                                new XElement("Property", new XElement("Property.Name", "Previously Attended Peirce"), new XElement("Value", new XCData(previouslyAttendPeirce))),
                                                new XElement("Property", new XElement("Property.Name", "Ethnicity"), new XElement("Value", new XCData(ethnicity))),
                                                new XElement("Property", new XElement("Property.Name", "SSN"), new XElement("Value", new XCData(ssn))),
                                                new XElement("Property", new XElement("Property.Name", "Date of Birth"), new XElement("Value", new XCData(dateOfBirth)))
                                            ),
                                            new XElement("Group",
                                                new XElement("Group.Name", "Employment"),
                                                new XElement("Property", new XElement("Property.Name", "Military Branch"), new XElement("Value", new XCData(militaryBranch))),
                                                new XElement("Property", new XElement("Property.Name", "Military Status"), new XElement("Value", new XCData(""))),
                                                new XElement("Property", new XElement("Property.Name", "Profession"), new XElement("Value", new XCData(""))),
                                                new XElement("Property", new XElement("Property.Name", "Profession Status"), new XElement("Value", new XCData(""))),
                                                new XElement("Property", new XElement("Property.Name", "Employer Name"), new XElement("Value", new XCData(currentlyEmployed))),
                                                new XElement("Property", new XElement("Property.Name", "Employer Tution Reimbursment"), new XElement("Value", new XCData("")))
                                            )),
                                        new XElement("Tab",
                                            new XElement("Tab.Name", "Previous School"),
                                            new XElement("Group",
                                                new XElement("Group.Name", "High School"),
                                                new XElement("Property", new XElement("Property.Name", "Completed GED"), new XElement("Value", new XCData(highSchoolGed))),
                                                new XElement("Property", new XElement("Property.Name", "High School Code"), new XElement("Value", new XCData(highSchoolGed)))
                                            ),
                                            new XElement("Group",
                                                new XElement("Group.Name", "College 1"),
                                                new XElement("Property", new XElement("Property.Name", "College 1 Code"), new XElement("Value", new XCData("")))
                                            ),
                                            new XElement("Group",
                                                new XElement("Group.Name", "College 2"),
                                                new XElement("Property", new XElement("Property.Name", "College 2 Code"), new XElement("Value", new XCData("")))
                                            ),
                                            new XElement("Group",
                                                new XElement("Group.Name", "College 3"),
                                                new XElement("Property", new XElement("Property.Name", "College 3 Code"), new XElement("Value", new XCData("")))
                                            ),
                                            new XElement("Group",
                                                new XElement("Group.Name", "College 4"),
                                                new XElement("Property", new XElement("Property.Name", "College 4 Code"), new XElement("Value", new XCData("")))
                                            )),
                                        new XElement("Tab",
                                            new XElement("Tab.Name", "Enrollment Information"),
                                            new XElement("Group",
                                                new XElement("Group.Name", "Recruiting Information"),
                                                new XElement("Property", new XElement("Property.Name", "Team"), new XElement("Value", new XCData(""))),
                                                new XElement("Property", new XElement("Property.Name", "Counselor"), new XElement("Value", new XCData(""))),
                                                new XElement("Property", new XElement("Property.Name", "Follow-Up"), new XElement("Value", new XCData(""))),
                                                new XElement("Property", new XElement("Property.Name", "Last Attempt"), new XElement("Value", new XCData("")))
                                            ),
                                            new XElement("Group",
                                                new XElement("Group.Name", "Admissions Information"),
                                                new XElement("Property", new XElement("Property.Name", "Degree Type"), new XElement("Value", new XCData(degreeType))),
                                                new XElement("Property", new XElement("Property.Name", "Program"), new XElement("Value", new XCData(program))),
                                                new XElement("Property", new XElement("Property.Name", "Concentration"), new XElement("Value", new XCData(concentration))),
                                                new XElement("Property", new XElement("Property.Name", "Academic Year"), new XElement("Value", new XCData(""))),
                                                new XElement("Property", new XElement("Property.Name", "Term"), new XElement("Value", new XCData(""))),
                                                new XElement("Property", new XElement("Property.Name", "Entrance Type"), new XElement("Value", new XCData(""))),
                                                new XElement("Property", new XElement("Property.Name", "Location"), new XElement("Value", new XCData(""))),
                                                new XElement("Property", new XElement("Property.Name", "Candidacy"), new XElement("Value", new XCData("")))
                                            ),
                                            new XElement("Group",
                                                new XElement("Group.Name", "Marketing Information"),
                                                new XElement("Property", new XElement("Property.Name", "Source Type"), new XElement("Value", new XCData(adSource))),
                                                new XElement("Property", new XElement("Property.Name", "Source Description"), new XElement("Value", new XCData(adDescription))),
                                                new XElement("Property", new XElement("Property.Name", "Source Notes"), new XElement("Value", new XCData(adNote))),
                                                new XElement("Property", new XElement("Property.Name", "Referring URL"), new XElement("Value", new XCData("")))
                                            ),
                                            new XElement("Group",
                                                new XElement("Group.Name", "Admissions Information"),
                                                new XElement("Property", new XElement("Property.Name", "Stage"), new XElement("Value", new XCData(stage))),
                                                new XElement("Property", new XElement("Property.Name", "Inquiry Date"), new XElement("Value", new XCData(currentDate))),
                                                new XElement("Property", new XElement("Property.Name", "Application Date"), new XElement("Value", new XCData(currentDate)))
                                            )))),
                                new XElement("Object",
                                    new XElement("ObjectID", "-1"),
                                    new XElement("LANG", "English"),
                                    new XElement("DLID", "1033"),
                                    new XElement("Object.Name", "Interaction"),
                                    new XElement("PropList",
                                        new XElement("Tab",
                                            new XElement("Tab.Name", "Properties"),
                                            new XElement("Group",
                                                new XElement("Group.Name"),
                                                new XElement("Property", new XElement("Property.Name", "DisplayName"), new XElement("Value", new XCData(fullName))),
                                                new XElement("Property", new XElement("Property.Name", "From"), new XElement("Value", new XCData(email))),
                                                new XElement("Property", new XElement("Property.Name", "Subject"), new XElement("Value", new XCData(formType))),
                                                new XElement("Property", new XElement("Property.Name", "Request"), new XElement("Value", new XCData(request)))
                                                )))));

            return x;
        }
    }
}
