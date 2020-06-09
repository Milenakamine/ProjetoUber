namespace ProjetoUber
{
    
    public class Usuario
    {
        //propriedade resumida
        public string nome { get; set; }

//propriedade completa 
        private int idade;

        public int Idade{
            get{ return idade; }
            set{
                if(idade>0){
                    idade=value;
                }
            }
        }

        public string Foto { get; set; }

        private string login = "milena@gmail.com";

        private string Senha = "00000";

        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; }



        public bool Login(string login, string senha){
            if(this.login==login && this.Senha== senha ){
                TokenLogin= "gnkdfjgnkdjfngkndfgkjndfgk";
                return true;
            }
           return false;

         }

         public void Logout(){
             TokenLogin="";
         }


        }
    }
