namespace ContactBook;

using System.Collections.Generic;

public static class ContactSeed
{
    public static List<Contact> Contacts = new List<Contact>
    {
        new Contact("James", "Carter", "212-555-0101", "james.carter@gmail.com"),
        new Contact("Maria", "Lopez", "305-555-0182", "maria.lopez@yahoo.com"),
        new Contact("Ethan", "Brooks", "415-555-0134", "ethan.brooks@outlook.com"),
        new Contact("Sophia", "Martinez", "312-555-0167", "sophia.martinez@hotmail.com"),
        new Contact("Liam", "Johnson", "713-555-0193", "liam.johnson@gmail.com"),
        new Contact("Olivia", "Smith", "602-555-0145", "olivia.smith@icloud.com"),
        new Contact("Noah", "Williams", "404-555-0178", "noah.williams@yahoo.com"),
        new Contact("Emma", "Davis", "503-555-0121", "emma.davis@protonmail.com"),
        new Contact("Ava", "Wilson", "617-555-0159", "ava.wilson@gmail.com"),
        new Contact("William", "Moore", "702-555-0112", "william.moore@outlook.com"),

        new Contact("Isabella", "Taylor", "214-555-0187", "isabella.taylor@gmail.com"),
        new Contact("Benjamin", "Anderson", "206-555-0143", "benjamin.anderson@yahoo.com"),
        new Contact("Mia", "Thomas", "347-555-0165", "mia.thomas@hotmail.com"),
        new Contact("Lucas", "Jackson", "512-555-0198", "lucas.jackson@gmail.com"),
        new Contact("Charlotte", "White", "720-555-0176", "charlotte.white@icloud.com"),
        new Contact("Henry", "Harris", "813-555-0132", "henry.harris@outlook.com"),
        new Contact("Amelia", "Martin", "919-555-0154", "amelia.martin@protonmail.com"),
        new Contact("Alexander", "Garcia", "480-555-0189", "alexander.garcia@gmail.com"),
        new Contact("Harper", "Martinez", "323-555-0117", "harper.martinez@yahoo.com"),
        new Contact("Mason", "Robinson", "615-555-0163", "mason.robinson@gmail.com"),

        new Contact("Evelyn", "Clark", "216-555-0141", "evelyn.clark@hotmail.com"),
        new Contact("Logan", "Rodriguez", "651-555-0175", "logan.rodriguez@outlook.com"),
        new Contact("Abigail", "Lewis", "904-555-0128", "abigail.lewis@gmail.com"),
        new Contact("Elijah", "Lee", "702-555-0196", "elijah.lee@yahoo.com"),
        new Contact("Emily", "Walker", "253-555-0149", "emily.walker@icloud.com"),
        new Contact("Daniel", "Hall", "407-555-0183", "daniel.hall@gmail.com"),
        new Contact("Ella", "Allen", "314-555-0162", "ella.allen@protonmail.com"),
        new Contact("Aiden", "Young", "619-555-0137", "aiden.young@gmail.com"),
        new Contact("Scarlett", "Hernandez", "773-555-0118", "scarlett.hernandez@yahoo.com"),
        new Contact("Jackson", "King", "860-555-0174", "jackson.king@outlook.com"),

        new Contact("Grace", "Wright", "915-555-0146", "grace.wright@gmail.com"),
        new Contact("Sebastian", "Lopez", "208-555-0191", "sebastian.lopez@hotmail.com"),
        new Contact("Chloe", "Hill", "502-555-0153", "chloe.hill@gmail.com"),
        new Contact("Matthew", "Scott", "347-555-0127", "matthew.scott@yahoo.com"),
        new Contact("Victoria", "Green", "612-555-0169", "victoria.green@icloud.com"),
        new Contact("Joseph", "Adams", "702-555-0185", "joseph.adams@gmail.com"),
        new Contact("Riley", "Baker", "757-555-0142", "riley.baker@protonmail.com"),
        new Contact("David", "Gonzalez", "404-555-0116", "david.gonzalez@gmail.com"),
        new Contact("Aria", "Nelson", "503-555-0178", "aria.nelson@yahoo.com"),
        new Contact("Carter", "Carter", "210-555-0194", "carter.carter@outlook.com"),

        new Contact("Lily", "Mitchell", "617-555-0131", "lily.mitchell@gmail.com"),
        new Contact("Owen", "Perez", "312-555-0157", "owen.perez@hotmail.com"),
        new Contact("Zoey", "Roberts", "415-555-0182", "zoey.roberts@gmail.com"),
        new Contact("Wyatt", "Turner", "214-555-0148", "wyatt.turner@yahoo.com"),
        new Contact("Penelope", "Phillips", "720-555-0173", "penelope.phillips@icloud.com"),
        new Contact("John", "Campbell", "813-555-0129", "john.campbell@gmail.com"),
        new Contact("Layla", "Parker", "919-555-0165", "layla.parker@protonmail.com"),
        new Contact("Luke", "Evans", "480-555-0197", "luke.evans@gmail.com"),
        new Contact("Nora", "Edwards", "323-555-0143", "nora.edwards@yahoo.com"),
        new Contact("Gabriel", "Collins", "615-555-0119", "gabriel.collins@outlook.com"),

        // Partial fields — no email
        new Contact("Ryan", "Stewart", "216-555-0186"),
        new Contact("Hannah", "Sanchez", "651-555-0152"),
        new Contact("Dylan", "Morris", "904-555-0174"),
        new Contact("Zoe", "Rogers", "702-555-0138"),
        new Contact("Nathan", "Reed", "253-555-0163"),
        new Contact("Leah", "Cook", "407-555-0191"),
        new Contact("Isaac", "Morgan", "314-555-0147"),
        new Contact("Aubrey", "Bell", "619-555-0172"),
        new Contact("Christian", "Murphy", "773-555-0126"),
        new Contact("Addison", "Bailey", "860-555-0184"),

        // Partial fields — no phone
        new Contact("Stella", "Rivera", "", "stella.rivera@gmail.com"),
        new Contact("Jonathan", "Cooper", "", "jonathan.cooper@yahoo.com"),
        new Contact("Savannah", "Richardson", "", "savannah.richardson@hotmail.com"),
        new Contact("Aaron", "Cox", "", "aaron.cox@icloud.com"),
        new Contact("Brooklyn", "Howard", "", "brooklyn.howard@protonmail.com"),
        new Contact("Eli", "Ward", "", "eli.ward@gmail.com"),
        new Contact("Bella", "Torres", "", "bella.torres@yahoo.com"),
        new Contact("Charles", "Peterson", "", "charles.peterson@outlook.com"),
        new Contact("Claire", "Gray", "", "claire.gray@gmail.com"),
        new Contact("Thomas", "Ramirez", "", "thomas.ramirez@hotmail.com"),

        // Partial fields — only first name and last name
        new Contact("Julian", "James"),
        new Contact("Natalie", "Watson"),
        new Contact("Hunter", "Brooks"),
        new Contact("Audrey", "Kelly"),
        new Contact("Dominic", "Sanders"),
        new Contact("Paisley", "Price"),
        new Contact("Brandon", "Bennett"),
        new Contact("Naomi", "Wood"),
        new Contact("Jeremiah", "Barnes"),
        new Contact("Elena", "Ross"),

        // Partial fields — only first name
        new Contact(fname: "Jasmine"),
        new Contact(fname: "Caleb"),
        new Contact(fname: "Madeline"),
        new Contact(fname: "Miles"),
        new Contact(fname: "Aurora"),

        // Partial fields — mixed combos
        new Contact("Ezra", "", "787-555-0101", "ezra@protonmail.com"),
        new Contact("", "Fleming", "939-555-0145", "fleming@gmail.com"),
        new Contact("Ruby", "Griffin", "787-555-0167", ""),
        new Contact("Connor", "Diaz", "", "connor.diaz@yahoo.com"),
        new Contact("Mackenzie", "Hayes", "939-555-0189", ""),
        new Contact("Adrian", "Myers", "787-555-0123", "adrian.myers@icloud.com"),
        new Contact("Peyton", "Ford", "", "peyton.ford@gmail.com"),
        new Contact("Sawyer", "Hamilton", "939-555-0156", ""),
        new Contact("Piper", "Graham", "787-555-0178", "piper.graham@outlook.com"),
        new Contact("Declan", "Sullivan", "939-555-0134", "declan.sullivan@yahoo.com"),
    };
}