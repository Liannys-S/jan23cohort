Melee olaf = new Melee("Olaf");
Ranged ashe = new Ranged("Ashe");
Magic veigar =  new Magic("Veigar");

olaf.PerformAttack(ashe, olaf.Kick);
olaf.Rage(veigar);
ashe.PerformAttack(olaf, ashe.Arrow);
ashe.Dash();
ashe.PerformAttack(olaf, ashe.Arrow);
veigar.PerformAttack(olaf, veigar.Fireball);
veigar.Heal(ashe);
veigar.Heal(veigar);
veigar.Heal(ashe);
veigar.Heal(ashe);
olaf.Rage(veigar);
olaf.Rage(veigar);
olaf.Rage(veigar);
olaf.Rage(veigar);
veigar.PerformAttack(olaf, veigar.Lightning);