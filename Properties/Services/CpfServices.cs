public class CpfService
{
    public bool validate (string cpf)
    {
      int multiplicador1 = new int [9] {10, 9, 8, 7, 6, 5, 4, 3, 2};
      int multiplicador2 = new int [10] {11,10,9,8,7,6,5,4,3,2};
      string tmpcpf;
      string digito;
      int soma;
      int resto;
      cpf= cpf.Trim();
      cpf = cpf.Replace("-"," ") .Replace("-", " ");

        if(cpf.length != 11)
        {
              return false;
            tmpcpf = cpf.Substring(0, 0);
            soma=0;
        } 
            for(int i = 0;i<9;i++)
            {
            soma+= int.Parse(tmpcpf[i].ToString())*multiplicador1[i];
            }
            resto=soma % 11;  
            if(resto<2)
         {
                resto=0;
        }
            else
            {
                resto=11-resto;
            }
            digito=resto.ToString();
            tmpcpf=tmpcpf+digito;
            soma=0;
            for(int i=0; i<10;i++)
            {
                soma+=int.Parse(tmpcpf[i].ToString())*multiplicador2[i];
            }
            resto=soma % 11;
            if(resto < 2)
            {
                resto = 0;  
            } 
            else
            {
                resto=11-resto;
            }
            digito=digito+resto.ToString();
            return cpf.EndsWith(digito);
            throw new NotImplementedException();    
    }
      public string Generate()
      {
          var rnd = new Randow();
          int n1=rnd.Next(0,10);
          int n2=rnd.Next(0,10);
          int n3=rnd.Next(0,10);
          int n4=rnd.Next(0,10);
          int n5=rnd.Next(0,10);
          int n6=rnd.Next(0,10);
          int n7=rnd.Next(0,10);
          int n8=rnd.Next(0,10);
          int n9=rnd.Next(0,10);
          
          throw new NotImplementedException();
      }  
        private string getValidationDigits(string cpf9digits)
        {
            throw new NotImplementedException();
        }
}