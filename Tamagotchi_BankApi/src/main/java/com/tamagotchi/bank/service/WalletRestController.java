package com.tamagotchi.bank.service;

import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.google.gson.Gson;
import com.tamagotchi.bank.model.Wallet;
import com.tamagotchi.bank.repository.WalletRepository;

@RestController
@RequestMapping("/Rest")
public class WalletRestController {
	@Autowired
	private WalletRepository repository;
	
	@GetMapping("/GetMoney/{id}")
	public double GetMoney(@PathVariable String id) {
		Wallet wallet = repository.findById(id).orElse(null);
		return wallet.Balance;
	}
	
	@PostMapping("/AddMoney/{id}/{amount}")
	public String AddMoney(@PathVariable String id, @PathVariable double amount) {
		Optional<Wallet> data = repository.findById(id);
		Wallet wallet = ConvertJson(data);
		
		wallet.Balance += amount;
		repository.save(wallet);
		
		return "Succesfully added money";
	}
	
	@PostMapping("/AddWallet")
	public void AddWallet(@RequestBody Wallet wallet) {
		repository.save(wallet);
	}
	
	@PostMapping("/UpdateWallet")
	public void UpdateWallet(@RequestBody Wallet wallet) {
		repository.save(wallet);	
	}
	
	private Wallet ConvertJson(Optional <Wallet> data) {
		Wallet wallet = new Gson().fromJson(data.toString(), Wallet.class);
		return wallet;
	}
}
