using family_guy_pokemon.Pokemon;

namespace family_guy_pokemon
{
    public partial class Form1 : Form
    {
        List<Pokemons> pokemons;
        Pokemons selectedPokemon;
        Pokemons monster;
        public Form1()
        {
            InitializeComponent();
            pokemons = new List<Pokemons>();
            pokemons.Add(new Peter());
            pokemons.Add(new Cleveland());
            pokemons.Add(new Glen());
            pokemons.Add(new Brian());

            this.monster = new Joe();
            this.pictureBox2.Image = this.monster.getImage();
            this.textBox3.Text = this.monster.getName();
            this.textBox4.Text = this.monster.getHp().ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = selectedPokemon.getHp().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = selectedPokemon.getHp().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = selectedPokemon.getHp().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = selectedPokemon.getHp().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int damage = this.monster.getDefense() - this.selectedPokemon.getAttack();
            int damaged = this.selectedPokemon.getDefense() - this.monster.getAttack();
            this.textBox2.Text = this.selectedPokemon.takeDamage(damage).ToString();
            this.textBox4.Text = this.monster.takeDamage(damaged).ToString();
            int currentMonsterHp = this.monster.getHp();
            if (currentMonsterHp <= 0) 
            {
                this.labelResult.Text = "You Win";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.selectedPokemon.getHp() > 0)
            {
                int heal = this.selectedPokemon.getHp() + 50;
                this.textBox2.Text = heal.ToString();
            }
        }
    }
}