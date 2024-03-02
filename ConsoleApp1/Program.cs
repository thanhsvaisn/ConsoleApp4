class Program
{
    static void Main(string[] args)
    {
        // Example usage
        HospitalMedicationManagement management = new HospitalMedicationManagement();

        // Adding medications
        management.AddMedication("Paracetamol", 100, 5.5, "Painkiller", new Dictionary<string, double> { { "Paracetamol", 500 } });
        management.AddMedication("Amoxicillin", 50, 10.75, "Antibiotic", new Dictionary<string, double> { { "Amoxicillin", 250 } });
        management.AddMedication("Ibuprofen", 75, 7.25, "Anti-inflammatory", new Dictionary<string, double> { { "Ibuprofen", 400 } });

        // Display medications by category
        management.DisplayMedicationsByCategory("Painkiller");

        // Display medication details
        management.DisplayMedicationDetails("Paracetamol");

        // Search for a medication
        management.SearchMedication("Ibuprofen");

        // Update medication information
        management.UpdateMedication("Paracetamol", 120, 6.0, new Dictionary<string, double> { { "Paracetamol", 500 } });

        // Delete a medication
        management.DeleteMedication("Amoxicillin");
    }
}