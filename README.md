# Employee_Register
Program written during classes to represent employee register in one of global company

As a guideline, take the fact that a corporation is characterized by three basic types of employees:

     Clerical worker: has the following characteristics relevant to the corporation:
         employee ID: unique for each employee within the entire corporation
         name
         last name
         age
         experience
         address of the building where he works: the address should consist of four elements:
             street names
             building number
             apartment number
             city names
         office position identifier: unique throughout the corporation
         intellect: expressed in iq on a scale of 70 - 150

     Manual worker: has the following characteristics relevant to the corporation:
         employee ID: unique for each employee within the entire corporation
         name
         last name
         age
         experience
         address of the building where he works: the address should consist of four elements:
             street names
             building number
             apartment number
             city names
         physical strength - expressed on a scale of 1 - 100

     Merchant: has the following characteristics relevant to corporations:
         employee ID: unique for each employee within the entire corporation
         name
         last name
         age
         experience
         address of the building where he works: the address should consist of four elements:
             street names
             building number
             apartment number
             city names
         effectiveness: expressed in three fixed types LOW, MEDIUM, HIGH
         commission amount: expressed as a percentage

The register should enable the following tasks to be performed:

     adding any of the employee types to the register
     removing an employee with a given employee ID from the register
     adding several employees of different types to the register at once
     displaying a list of all employees sorted by the number of years of experience (descending), then by employee's age (ascending), then by employee's last name (in alphabetical order)
     displaying a list of employees who work in the city by the name given as an input parameter
     displaying a list of all employees along with their value to the corporation, with the degree of value calculated differently for each type of employee:
         for an office worker: the value for a corporation is calculated using the formula: experience * intellect
         for a manual worker: the value for a corporation is calculated using the formula experience * strength / age
         for the merchant: the value for the corporation is calculated using the formula experience * effectiveness, where the appropriate type of effectiveness is converted into value
             LOW: 60
             AVERAGE: 90
             HIGH: 120
