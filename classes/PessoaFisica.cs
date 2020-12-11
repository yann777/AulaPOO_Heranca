namespace POO_Heranca.classes
{
    public class PessoaFisica : Pessoa
    {
        public string cpf;
        public string rg;
        public bool ValidarCPF(string documento){
            
            if(documento != ""){
                return true;
            }
            // DarBoasVindas("Yan");
            // nome = "Exemplo";
            return true;
        }
    }
}