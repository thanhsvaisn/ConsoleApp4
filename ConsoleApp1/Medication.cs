using System;
using System.Collections.Generic;

// Class to represent a medication
class Medication
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public string Category { get; set; }
    public Dictionary<string, double> Ingredients { get; set; }

    public Medication(string name, int quantity, double price, string category, Dictionary<string, double> ingredients)
    {
        Name = name;
        Quantity = quantity;
        Price = price;
        Category = category;
        Ingredients = ingredients;
    }
}

// Main class
class HospitalMedicationManagement
{
    // List to store medications
    private List<Medication> medications = new List<Medication>();

    // Method to add a new medication
    public void AddMedication(string name, int quantity, double price, string category, Dictionary<string, double> ingredients)
    {
        Medication newMedication = new Medication(name, quantity, price, category, ingredients);
        medications.Add(newMedication);
        Console.WriteLine("New medication added successfully!");
    }

    // Method to display medications by category
    public void DisplayMedicationsByCategory(string category)
    {
        Console.WriteLine($"Medications in category '{category}':");
        foreach (var medication in medications)
        {
            if (medication.Category == category)
            {
                Console.WriteLine($"Name: {medication.Name}, Quantity: {medication.Quantity}, Price: {medication.Price}");
            }
        }
    }

    // Method to display details of a medication
    public void DisplayMedicationDetails(string name)
    {
        foreach (var medication in medications)
        {
            if (medication.Name == name)
            {
                Console.WriteLine($"Medication Details:");
                Console.WriteLine($"Name: {medication.Name}");
                Console.WriteLine($"Quantity: {medication.Quantity}");
                Console.WriteLine($"Price: {medication.Price}");
                Console.WriteLine($"Category: {medication.Category}");
                Console.WriteLine($"Ingredients:");
                foreach (var ingredient in medication.Ingredients)
                {
                    Console.WriteLine($"- {ingredient.Key}: {ingredient.Value} mg");
                }
                return;
            }
        }
        Console.WriteLine("Medication not found!");
    }

    // Method to search for a medication by name
    public void SearchMedication(string name)
    {
        foreach (var medication in medications)
        {
            if (medication.Name.ToLower() == name.ToLower())
            {
                DisplayMedicationDetails(medication.Name);
                return;
            }
        }
        Console.WriteLine("Medication not found!");
    }

    // Method to update medication information
    public void UpdateMedication(string name, int quantity, double price, Dictionary<string, double> ingredients)
    {
        foreach (var medication in medications)
        {
            if (medication.Name == name)
            {
                medication.Quantity = quantity;
                medication.Price = price;
                medication.Ingredients = ingredients;
                Console.WriteLine("Medication information updated successfully!");
                return;
            }
        }
        Console.WriteLine("Medication not found!");
    }

    // Method to delete a medication
    public void DeleteMedication(string name)
    {
        for (int i = 0; i < medications.Count; i++)
        {
            if (medications[i].Name == name)
            {
                medications.RemoveAt(i);
                Console.WriteLine("Medication deleted successfully!");
                return;
            }
        }
        Console.WriteLine("Medication not found!");
    }
}