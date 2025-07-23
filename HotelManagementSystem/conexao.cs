using MySql.Data.MySqlClient;
using System; // Usado para o Exception

// Este é o nosso "cantinho" para a conexão
public class Conexao
{
    // 2. Aqui guardamos o "endereço" do banco de dados.
    //    Lembre-se de trocar pela SUA senha do MySQL!
    private const string connectionString = "Server=localhost;Database=hoteldb;Uid=root;Pwd=admin123;";

    // 3. Esta é a "ponte" real para o banco de dados.
    private MySqlConnection connection;

    // 4. Este é o construtor. Ele "constrói" o objeto de conexão quando a classe é usada.
    public Conexao()
    {
        // Cria uma nova instância da conexão com o endereço que definimos.
        connection = new MySqlConnection(connectionString);
    }

    // 5. Um método para ABRIR a conexão com o banco.
    public MySqlConnection Abrir()
    {
        try
        {
            // Verifica se a conexão já não está aberta
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        catch (MySqlException ex)
        {
            // Se der erro (ex: senha errada), ele mostra uma mensagem.
            throw new Exception("Não foi possível conectar ao banco de dados. Erro: " + ex.Message);
        }
        return connection;
    }

    // 6. Um método para FECHAR a conexão. É MUITO importante sempre fechar a ponte!
    public void Fechar()
    {
        if (connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }
}