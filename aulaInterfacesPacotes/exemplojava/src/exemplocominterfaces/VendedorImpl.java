package exemplocominterfaces;

public class VendedorImpl implements Vendedor {
    private Gerente chefe;
    private String nome;
    private double salario;

    public String getMetodoSoNoVendor(){
        return "metodo do vendedor";
    }

    public String getTelefone(){
        return "+55549999999";
    }

    public Gerente getChefe(){
        return chefe;
    }

    public void setChefe(Gerente novoChefe){
        chefe = novoChefe;
    }

    @Override
    public String getNome() {
        return nome;
    }

    @Override
    public void setNome(String novoNome) {
        nome = novoNome;    
    }

    @Override
    public double getSalario() {
        return salario;
    }

    @Override
    public void setSalario(double novoSalario) {
        salario = novoSalario;
    }

    @Override
    public String imprimirDescricao() {
        return getNome() + " " + getSalario();
    }
}
