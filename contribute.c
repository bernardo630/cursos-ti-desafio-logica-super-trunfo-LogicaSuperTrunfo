#include <stdio.h>
#include <string.h>

typedef struct {
    char estado[50];
    char codigo[20];
    char nome[50];
    int populacao;
    double area;
    double pib;
    int pontosTuristicos;
} CartaCidade;

double calcularDensidadePopulacional(CartaCidade c) {
    return c.populacao / c.area;
}

void exibirCarta(CartaCidade c) {
    printf("\n--- Carta da Cidade ---\n");
    printf("Estado: %s\n", c.estado);
    printf("Código: %s\n", c.codigo);
    printf("Nome: %s\n", c.nome);
    printf("População: %d\n", c.populacao);
    printf("Área: %.2f\n", c.area);
    printf("PIB: %.2f\n", c.pib);
    printf("Pontos Turísticos: %d\n", c.pontosTuristicos);
    printf("Densidade Populacional: %.2f\n", calcularDensidadePopulacional(c));
}

CartaCidade cadastrarCarta() {
    CartaCidade c;

    printf("Estado: ");
    fgets(c.estado, sizeof(c.estado), stdin);
    c.estado[strcspn(c.estado, "\n")] = '\0'; // remover \n

    printf("Código da carta: ");
    fgets(c.codigo, sizeof(c.codigo), stdin);
    c.codigo[strcspn(c.codigo, "\n")] = '\0';

    printf("Nome da cidade: ");
    fgets(c.nome, sizeof(c.nome), stdin);
    c.nome[strcspn(c.nome, "\n")] = '\0';

    printf("População: ");
    scanf("%d", &c.populacao);

    printf("Área: ");
    scanf("%lf", &c.area);

    printf("PIB: ");
    scanf("%lf", &c.pib);

    printf("Nº de pontos turísticos: ");
    scanf("%d", &c.pontosTuristicos);

    getchar(); // limpa o buffer
    return c;
}

void compararCartas(CartaCidade c1, CartaCidade c2, int opcao) {
    if (opcao == 1) {
        if (c1.populacao > c2.populacao)
            printf("Vencedora: %s (maior população)\n", c1.nome);
        else if (c2.populacao > c1.populacao)
            printf("Vencedora: %s (maior população)\n", c2.nome);
        else
            printf("Empate na população!\n");
    } else if (opcao == 2) {
        if (c1.area > c2.area)
            printf("Vencedora: %s (maior área)\n", c1.nome);
        else if (c2.area > c1.area)
            printf("Vencedora: %s (maior área)\n", c2.nome);
        else
            printf("Empate na área!\n");
    } else if (opcao == 3) {
        if (c1.pib > c2.pib)
            printf("Vencedora: %s (maior PIB)\n", c1.nome);
        else if (c2.pib > c1.pib)
            printf("Vencedora: %s (maior PIB)\n", c2.nome);
        else
            printf("Empate no PIB!\n");
    } else if (opcao == 4) {
        if (c1.pontosTuristicos > c2.pontosTuristicos)
            printf("Vencedora: %s (mais pontos turísticos)\n", c1.nome);
        else if (c2.pontosTuristicos > c1.pontosTuristicos)
            printf("Vencedora: %s (mais pontos turísticos)\n", c2.nome);
        else
            printf("Empate nos pontos turísticos!\n");
    } else if (opcao == 5) {
        double dens1 = calcularDensidadePopulacional(c1);
        double dens2 = calcularDensidadePopulacional(c2);

        if (dens1 < dens2)
            printf("Vencedora: %s (menor densidade populacional)\n", c1.nome);
        else if (dens2 < dens1)
            printf("Vencedora: %s (menor densidade populacional)\n", c2.nome);
        else
            printf("Empate na densidade populacional!\n");
    } else {
        printf("Opção inválida!\n");
    }
}

int main() {
    printf("Cadastro da Carta 1:\n");
    CartaCidade carta1 = cadastrarCarta();

    printf("\nCadastro da Carta 2:\n");
    CartaCidade carta2 = cadastrarCarta();

    exibirCarta(carta1);
    exibirCarta(carta2);

    printf("\nEscolha o atributo para comparar:\n");
    printf("1 - População\n");
    printf("2 - Área\n");
    printf("3 - PIB\n");
    printf("4 - Pontos Turísticos\n");
    printf("5 - Densidade Populacional\n");

    int opcao;
    printf("Digite a opção: ");
    scanf("%d", &opcao);
    getchar(); // limpa buffer

    printf("\nResultado da comparação:\n");
    compararCartas(carta1, carta2, opcao);

    return 0;
}
