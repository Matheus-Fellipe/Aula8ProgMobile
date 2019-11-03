using System;
using Xamarin.Forms;
using XF.LocalDB.AlunoViewModel;
using XF.LocalDB.View.Aluno;

public partial class MainPage : ContentPage
{
    AlunoViewModel vmAluno;
    public MainPage()
    {
        vmAluno = new AlunoViewModel();
        BindingContext = vmAluno;
        InitializeComponent();
    }
    protected override void OnAppearing()
    {
        vmAluno = new AlunoViewModel();
        BindingContext = vmAluno;
        base.OnAppearing();
    }
    private void OnNovo(object sender, EventArgs args)
    {
        Navigation.PushAsync(new NovoAlunoView());
    }
    private void OnAlunoTapped(object sender,
    ItemTappedEventArgs args)
    {
        var selecionado = args.Item as XF.LocalDB.Model.Aluno;
        DisplayAlert("Aluno selecionado", "Aluno: " +
        selecionado.Id, "OK");
    }
}