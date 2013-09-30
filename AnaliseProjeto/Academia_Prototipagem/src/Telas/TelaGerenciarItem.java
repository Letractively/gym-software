/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/*
 * TelaGerenciarItem.java
 *
 * Created on 21/07/2011, 12:59:03
 */
package Telas;

import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import javax.swing.ListSelectionModel;


/**
 *
 * @author Islas
 */
public class TelaGerenciarItem extends javax.swing.JFrame {


    public TelaGerenciarItem() throws Exception {

        //codigo pra permitir abrir a janela novamente após fechar
        this.addWindowListener(new WindowAdapter() {
        @Override
        public void windowClosing(WindowEvent evt) {
           
            dispose();
        }
            }  );


        initComponents();
    }

    /** This method is called from within the constructor to
     * initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is
     * always regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        editar = new javax.swing.JButton();
        addNovo = new javax.swing.JButton();
        remover = new javax.swing.JButton();
        lançamento = new javax.swing.JButton();
        sair = new javax.swing.JButton();
        jScrollPane2 = new javax.swing.JScrollPane();
        jTable2 = new javax.swing.JTable();
        jButton1 = new javax.swing.JButton();
        jComboBox1 = new javax.swing.JComboBox();
        jTPalavra = new javax.swing.JTextField();
        jLabel2 = new javax.swing.JLabel();
        jButton2 = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        jCheckBox1 = new javax.swing.JCheckBox();
        jCheckBox2 = new javax.swing.JCheckBox();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("Gerência de Estoque");

        editar.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        editar.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagens/Script-Edit.png"))); // NOI18N
        editar.setText("Alterar Item");
        editar.setToolTipText("Selecione um produto e clique aqui para alterar as informações");
        editar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                editarActionPerformed(evt);
            }
        });

        addNovo.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        addNovo.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagens/Package-Add.png"))); // NOI18N
        addNovo.setText("Inserir Novo Item");
        addNovo.setToolTipText("Clique aqui para adicionar um novo produto no banco de dados");
        addNovo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                addNovoActionPerformed(evt);
            }
        });

        remover.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        remover.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagens/Package-Delete.png"))); // NOI18N
        remover.setText("Excluir Item");
        remover.setToolTipText("Selecione um produto da lista e clique aqui para remover do banco de dados");
        remover.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                removerActionPerformed(evt);
            }
        });

        lançamento.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        lançamento.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagens/Package-Go.png"))); // NOI18N
        lançamento.setText("Lançar Item");
        lançamento.setToolTipText("Selecione um produto e clique aqui para adicionar mais");
        lançamento.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                lançamentoActionPerformed(evt);
            }
        });

        sair.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        sair.setText("Voltar");
        sair.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                sairActionPerformed(evt);
            }
        });

        jTable2.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        jTable2.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Cod. de Barras", "Descrição", "Quantidade", "Preço de Custo", "Preço de Venda", "Qnt. Mínima", "Fornecedor"
            }
        ));
        jTable2.getTableHeader().setFont(new java.awt.Font("Tahoma", 0, 12));
        jTable2.setFocusable(false);
        jTable2.setRequestFocusEnabled(false);
        jTable2.setRowHeight(20);
        jTable2.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
        jTable2.getColumnModel().getColumn(0).setPreferredWidth(70);
        jTable2.getColumnModel().getColumn(1).setPreferredWidth(170);
        jTable2.getColumnModel().getColumn(2).setPreferredWidth(65);
        jTable2.getColumnModel().getColumn(4).setPreferredWidth(65);
        jTable2.getColumnModel().getColumn(5).setPreferredWidth(65);
        jTable2.getColumnModel().getColumn(6).setPreferredWidth(80);
        jScrollPane2.setViewportView(jTable2);

        jButton1.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        jButton1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagens/Table-Refresh.png"))); // NOI18N
        jButton1.setText("Exibir Todos Itens");
        jButton1.setToolTipText("Clique aqui para exibir todos os produtos do banco de dados");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        jComboBox1.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        jComboBox1.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Descrição", "Código de Barra", "Fornecedor" }));

        jTPalavra.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        jTPalavra.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jTPalavraActionPerformed(evt);
            }
        });
        jTPalavra.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                jTPalavraKeyPressed(evt);
            }
        });

        jLabel2.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        jLabel2.setText("Buscar por:");

        jButton2.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        jButton2.setText("Pesquisar");
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });

        jLabel1.setText("Exibir:");

        jCheckBox1.setSelected(true);
        jCheckBox1.setText("Produtos");

        jCheckBox2.setSelected(true);
        jCheckBox2.setText("Aparelhos");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(59, 59, 59)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel1)
                        .addGap(18, 18, 18)
                        .addComponent(jCheckBox1)
                        .addGap(6, 6, 6)
                        .addComponent(jCheckBox2)
                        .addContainerGap())
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(jLabel2)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(jTPalavra, javax.swing.GroupLayout.DEFAULT_SIZE, 492, Short.MAX_VALUE)
                                .addGap(30, 30, 30)
                                .addComponent(jComboBox1, javax.swing.GroupLayout.PREFERRED_SIZE, 122, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(26, 26, 26)
                                .addComponent(jButton2, javax.swing.GroupLayout.PREFERRED_SIZE, 125, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(32, 32, 32))
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 874, Short.MAX_VALUE)
                                .addGap(18, 18, 18)))
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(sair, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(jButton1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(lançamento, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(remover, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(addNovo, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(editar, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                        .addGap(22, 22, 22))))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(41, 41, 41)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(jTPalavra, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jButton2)
                    .addComponent(jComboBox1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 27, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(jCheckBox1)
                    .addComponent(jCheckBox2))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(addNovo)
                        .addGap(18, 18, 18)
                        .addComponent(remover)
                        .addGap(16, 16, 16)
                        .addComponent(lançamento)
                        .addGap(18, 18, 18)
                        .addComponent(editar, javax.swing.GroupLayout.PREFERRED_SIZE, 39, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(jButton1)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(sair))
                    .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 462, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(44, 44, 44))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void lançamentoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_lançamentoActionPerformed
      
}//GEN-LAST:event_lançamentoActionPerformed

    private void sairActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_sairActionPerformed
       
    }//GEN-LAST:event_sairActionPerformed
    

    private void removerActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_removerActionPerformed
      
    }//GEN-LAST:event_removerActionPerformed
   

                private void addNovoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_addNovoActionPerformed
  
                }//GEN-LAST:event_addNovoActionPerformed

                private void editarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_editarActionPerformed


                }//GEN-LAST:event_editarActionPerformed

                private void jTPalavraActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jTPalavraActionPerformed
                    // TODO add your handling code here:
}//GEN-LAST:event_jTPalavraActionPerformed

                private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed

 
                }//GEN-LAST:event_jButton2ActionPerformed

                private void jTPalavraKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_jTPalavraKeyPressed

   
                }//GEN-LAST:event_jTPalavraKeyPressed

                private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
                
                }//GEN-LAST:event_jButton1ActionPerformed

    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {

            public void run() {
                try {
                    new TelaGerenciarItem().setVisible(true);
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton addNovo;
    private javax.swing.JButton editar;
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JCheckBox jCheckBox1;
    private javax.swing.JCheckBox jCheckBox2;
    private javax.swing.JComboBox jComboBox1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JTextField jTPalavra;
    public static javax.swing.JTable jTable2;
    private javax.swing.JButton lançamento;
    private javax.swing.JButton remover;
    private javax.swing.JButton sair;
    // End of variables declaration//GEN-END:variables
}