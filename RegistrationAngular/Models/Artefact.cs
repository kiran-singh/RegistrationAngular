namespace RegistrationAngular.Models
{
    public class Artefact
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Barcode { get; set; }

        public string BarcodePartial
        {
            get { return string.IsNullOrWhiteSpace(Barcode) ? "_NoBarcodePartial" : "_BarcodePartial"; }
        }

        public string Item { get; set; }
    }
}