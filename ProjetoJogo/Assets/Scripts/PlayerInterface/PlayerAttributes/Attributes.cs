using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attributes : MonoBehaviour
{
    public Text forcaText;
    public Text destrezaText;
    public Text constituicaoText;
    public Text inteligenciaText;
    public Text sabedoriaText;
    public Text carismaText;

    public Button aumentarForcaBtn;
    public Button diminuirForcaBtn;
    public Button aumentarDestrezaBtn;
    public Button diminuirDestrezaBtn;
    public Button aumentarConstituicaoBtn;
    public Button diminuirConstituicaoBtn;
    public Button aumentarInteligenciaBtn;
    public Button diminuirInteligenciaBtn;
    public Button aumentarSabedoriaBtn;
    public Button diminuirSabedoriaBtn;
    public Button aumentarCarismaBtn;
    public Button diminuirCarismaBtn;

    public Text pontosDisponiveisText;

    private int pontosDisponiveis = 5;

    private int forca;
    private int destreza;
    private int constituicao;
    private int inteligencia;
    private int sabedoria;
    private int carisma;

    void Start()
    {
        // Inicialização dos botões e textos
        aumentarForcaBtn.onClick.AddListener(() => AumentarAtributo("Forca"));
        diminuirForcaBtn.onClick.AddListener(() => DiminuirAtributo("Forca"));
        aumentarDestrezaBtn.onClick.AddListener(() => AumentarAtributo("Destreza"));
        diminuirDestrezaBtn.onClick.AddListener(() => DiminuirAtributo("Destreza"));
        aumentarConstituicaoBtn.onClick.AddListener(() => AumentarAtributo("Constituicao"));
        diminuirConstituicaoBtn.onClick.AddListener(() => DiminuirAtributo("Constituicao"));
        aumentarInteligenciaBtn.onClick.AddListener(() => AumentarAtributo("Inteligencia"));
        diminuirInteligenciaBtn.onClick.AddListener(() => DiminuirAtributo("Inteligencia"));
        aumentarSabedoriaBtn.onClick.AddListener(() => AumentarAtributo("Sabedoria"));
        diminuirSabedoriaBtn.onClick.AddListener(() => DiminuirAtributo("Sabedoria"));
        aumentarCarismaBtn.onClick.AddListener(() => AumentarAtributo("Carisma"));
        diminuirCarismaBtn.onClick.AddListener(() => DiminuirAtributo("Carisma"));

        AtualizarUI();
    }

    void AumentarAtributo(string atributo)
    {
        if (pontosDisponiveis > 0)
        {
            switch (atributo)
            {
                case "Forca":
                    forca++;
                    break;
                case "Destreza":
                    destreza++;
                    break;
                case "Constituicao":
                    constituicao++;
                    break;
                case "Inteligencia":
                    inteligencia++;
                    break;
                case "Sabedoria":
                    sabedoria++;
                    break;
                case "Carisma":
                    carisma++;
                    break;
            }

            pontosDisponiveis--;
            AtualizarUI();
        }
    }

    void DiminuirAtributo(string atributo)
    {
        switch (atributo)
        {
            case "Forca":
                if (forca > 0)
                {
                    forca--;
                    pontosDisponiveis++;
                    AtualizarUI();
                }
                break;
            case "Destreza":
                if (destreza > 0)
                {
                    destreza--;
                    pontosDisponiveis++;
                    AtualizarUI();
                }
                break;
            case "Constituicao":
                if (constituicao > 0)
                {
                    constituicao--;
                    pontosDisponiveis++;
                    AtualizarUI();
                }
                break;
            case "Inteligencia":
                if (inteligencia > 0)
                {
                    inteligencia--;
                    pontosDisponiveis++;
                    AtualizarUI();
                }
                break;
            case "Sabedoria":
                if (sabedoria > 0)
                {
                    sabedoria--;
                    pontosDisponiveis++;
                    AtualizarUI();
                }
                break;
            case "Carisma":
                if (carisma > 0)
                {
                    carisma--;
                    pontosDisponiveis++;
                    AtualizarUI();
                }
                break;
        }
    }

    void AtualizarUI()
    {
        forcaText.text = "Força: " + forca;
        destrezaText.text = "Destreza: " + destreza;
        constituicaoText.text = "Constituição: " + constituicao;
        inteligenciaText.text = "Inteligência: " + inteligencia;
        sabedoriaText.text = "Sabedoria: " + sabedoria;
        carismaText.text = "Carisma: " + carisma;

        pontosDisponiveisText.text = "Pontos Disponíveis: " + pontosDisponiveis;
    }
}