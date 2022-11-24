class Cadastro
{
    //atributos privados
    private string nome;
    private string username;
    private string email;
    private string senha;
    private string confirmaSenha;
    private string cpf;
    private string estado;
    private string cep;
    private int idade;
    private string sexo;
    private string telefone;
    private string celular;

    public Cadastro()
    {
        this.nome = "";
        this.username = "";
        this.email = "";
        this.senha = "";
        this.confirmaSenha = "";
        this.cpf = "";
        this.estado = "";
        this.cep = "";
        this.idade = 0;
        this.sexo = "";        
        this.telefone = "";
        this.celular = "";
    }




    public Cadastro(
        string p_nome,
        string p_username,
        string p_email,
        string p_senha,
        string p_confirmaSenha,
        string p_cpf,
        string p_estado,
        string p_cep,
        int p_idade,
        string p_sexo,
        string p_telefone,
        string p_celular
        )
    {
        this.nome = p_nome;
        this.username = p_username;
        this.email = p_email;
        this.senha = p_senha;
        this.confirmaSenha = p_confirmaSenha;
        this.cpf = p_cpf;
        this.estado = p_estado;
        this.cep = p_cep;
        this.idade = p_idade;
        this.sexo = p_sexo;
        this.telefone = p_telefone;
        this.celular = p_celular;
    }

    // Nome
    public string getNome() { return this.nome; }
    public void setNome(string p_nome) { this.nome = p_nome; }

    //Username
    public string getUsername() { return this.username; }
    public void setUsername(string p_username) { this.username = p_username; }

    // Email
    public string getEmail() { return this.email; }
    public void setEmail(string p_email) { this.email = p_email; }

    //Senha
    public string getSenha() { return this.senha; }
    public void setSenha(string p_senha) { this.senha = p_senha; }

    //Confirma senha
    public string getConfirmaSenha() { return this.confirmaSenha; }
    public void setConfirmaSenha(string p_confirmaSenha) { this.confirmaSenha = p_confirmaSenha; }

    //Cpf
    public string getCPf() { return this.cpf; }
    public void setCPf(string p_cpf) { this.cpf = p_cpf; }

    //Estado
    public string getEstado() { return this.estado; }
    public void setEstado(string p_estado) { this.estado = p_estado;}

    //Cep
    public string getCep() { return this.cep; }
    public void setCep(string p_cep) { this.cep = p_cep; }

    //Idade
    public int getIdade() { return this.idade; }
    public void setIdade(int p_idade) { this.idade = p_idade; }

    //Sexo
    public string getSexo() { return this.sexo; }
    public void setSexo(string p_sexo) { this.sexo = p_sexo; }

    //Telefone
    public string getTelefone() { return this.telefone; }
    public void setTelefone(string p_telefone) { this.telefone = p_telefone; }

    //Celular
    public string getCelular() { return this.celular; }
    public void setCelular(string p_celular) { this.celular = p_celular; }

}
